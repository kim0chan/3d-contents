using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    float player_x;
    float new_x;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player_x = playerObject.transform.position.x;
        new_x = Mathf.Lerp(new_x, player_x, Time.deltaTime);
        Vector3 camera_vec = new Vector3(new_x * 0.5f, 25, -45);
        this.transform.position = camera_vec;
    }
}
