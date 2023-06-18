using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle_gameover : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject Score;
    Score scoreScript;
    public GameObject BestScore;
    public AudioClip DDT;
    private bool isOver;
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.name == "Player") {
            GameOver();

            //int currentScore = scoreComponent.score;
            //Score scoreScript = Score.GetComponent<Score>();
            //int bestScore = scoreScript.score;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject parentObject = GameObject.Find("UI_Test"); 
        GameOverText = parentObject.transform.Find("GameOver").gameObject;
        Score = parentObject.transform.Find("Score").gameObject;
        scoreScript = Score.GetComponent<Score>();
        BestScore = parentObject.transform.Find("BestScore").gameObject;
        isOver = false;
        Time.timeScale = 1;
    }

    void GameOver() {
        GetComponent<AudioSource>().PlayOneShot(DDT);
        GameOverText.SetActive(true);
        scoreScript.UpdateBestScore();
        Time.timeScale = 0;
        isOver = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if(isOver) {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
