using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFlag : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip FlagHit;
    Score scoreScript;
    private float flagHitScore = 10.0f;
    void Start()
    {
        scoreScript = FindObjectOfType<Score>();
    }

    void OnTriggerEnter(Collider col) {        if(col.gameObject.name == "Player") {
            GetComponent<AudioSource>().PlayOneShot(FlagHit);
            GetComponent<Animator>().SetBool("isHit", true);
            // Debug.Log("animation gogo!");
            scoreScript.ScoreUpByCollision(flagHitScore);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
