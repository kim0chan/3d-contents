using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_gameover : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject Score;
    public GameObject BestScore;
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.name == "Player") {
            Debug.Log("Yikes!");
            GameOverText.SetActive(true);
            Time.timeScale = 0;

            //int currentScore = scoreComponent.score;
            //Score scoreScript = Score.GetComponent<Score>();
            //int bestScore = scoreScript.score;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
