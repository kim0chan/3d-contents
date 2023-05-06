using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float score {get; set;}
    public static float scoreFactor = 1.0f;
    public static float endGameScoreFactor = 3.0f;
    Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard = GetComponent<Text>();
        score = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreFactor;
        scoreFactor = Mathf.Lerp(scoreFactor, endGameScoreFactor, Time.deltaTime);
        ScoreBoard.text = score.ToString("0") + "점";
    }
}
