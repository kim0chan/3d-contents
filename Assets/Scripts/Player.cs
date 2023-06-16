using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioClip Turn;
    public AudioClip StarCollected;
    private const float EPS = 0.01f;

    public float moveDir = 1.0f;        // Direction for movement. 1 for RIGHT and -1 for LEFT
    public float currentDir = 1.0f;     // A variable for controlling current movement speed
    public float interpolation = 1.0f;  // A variable for interpolation(Lerp)
    public bool isChangingDir = false;  // Movement constraint
    public float moveSpeed = 8f;        // Movement speed factor
    public float endgame_moveSpeed = 16.0f; // Maximum movement speed
    public float dirChangeSpeed = 2f;   // Direction change speed factor

    public Vector3 dirRight = new Vector3(1f, 0, 0);    // Vector RIGHT
    public Vector3 dirLeft = new Vector3(-1f, 0, 0);    // Vector LEFT
    public float rotRight = -30f, rotLeft = 30f;        // Player angle
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.name == "Star_yellow(Clone)") {
            Debug.Log("야호");
            GetComponent<AudioSource>().PlayOneShot(StarCollected);
        }
    }
    float ABS(float a)      // Returns absolute value
    {
        if (a < 0) return -a;
        return a;
    }
    void Start()
    {
        this.transform.eulerAngles = new Vector3(0, rotRight, 0);   // Initial player angle configuration
    }

    void Update()
    {
        interpolation = (currentDir + 1) / 2;

        /// Key Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isChangingDir)
            {
                GetComponent<AudioSource>().PlayOneShot(Turn);
                moveDir *= -1;
                isChangingDir = true;
            }
        }

        /// Direction Change
        if (isChangingDir)
        {
            if(ABS(moveDir - currentDir) > EPS)
            {
                this.transform.eulerAngles = new Vector3(0, Mathf.Lerp(rotLeft, rotRight, interpolation), 0);
                currentDir += moveDir * dirChangeSpeed * Time.deltaTime;
            }
            else
            {
                currentDir = moveDir;
                isChangingDir = false;
            }
        }
        /// Bug Handling
        if(currentDir < -1.01f)
        {
            currentDir = -1.0f;
        }
        if(currentDir > 1.01f)
        {
            currentDir = 1.0f;
        }


        /// Player translation
        this.transform.position += Vector3.Lerp(dirLeft, dirRight, interpolation) * moveSpeed * Time.deltaTime;
        moveSpeed = Mathf.Lerp(moveSpeed, endgame_moveSpeed, 0.01f * Time.deltaTime);
    }
}
