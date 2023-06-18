using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextToggle : MonoBehaviour
{
    private Text text;
    private bool isDay = true;
    private Color DayColor;
    private Color NightColor;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        DayColor = new Color(0.25f, 0.25f, 0.25f);
        NightColor = new Color(1.0f, 1.0f, 1.0f);
    }

    void ChangeLight(bool isDay) {
        if (isDay) {
            text.color = NightColor;
        }
        else {
            text.color = DayColor;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))  {
            ChangeLight(isDay);
            isDay = !isDay;
        }
    }
}
