using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_gameover : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.name == "Player") {
            Debug.Log("Yikes!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
