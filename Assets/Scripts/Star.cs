using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    Score scoreScript;
    private float starHitScore = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<Score>();
    }

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.name == "Player") {
            gameObject.SetActive(false);
            scoreScript.ScoreUpByCollision(starHitScore);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
