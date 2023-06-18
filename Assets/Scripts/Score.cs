using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score {get; set;}
    public static float scoreFactor = 1.0f;
    public static float endGameScoreFactor = 3.0f;
    public float BestScore;
    Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard = GetComponent<Text>();
        score = 0.0f;
        BestScore = PlayerPrefs.GetInt("BestScore");
    }

    public void ScoreUpByCollision(float collisionScore) {
        score += collisionScore * scoreFactor;
    }

    public void UpdateBestScore() {
        if(score > BestScore) {
            PlayerPrefs.SetInt("BestScore", (int)score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreFactor;
        scoreFactor = Mathf.Lerp(scoreFactor, endGameScoreFactor, Time.deltaTime);
        ScoreBoard.text = score.ToString("0") + "점";
    }
}
