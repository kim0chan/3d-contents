using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public int bestScore {get; set;}
    Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard = GetComponent<Text>();
        bestScore = PlayerPrefs.GetInt("BestScore");
        ScoreBoard.text = "Best: " + bestScore.ToString() + "점";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
