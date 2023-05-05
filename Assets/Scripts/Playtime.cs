using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playtime : MonoBehaviour
{
    public float score;
    Text ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        ScoreBoard = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        ScoreBoard.text = "Play Time: " + score.ToString("0");
    }
}
