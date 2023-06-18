using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelToggle : MonoBehaviour
{
    private Image panel;
    private bool isDay = true;
    private Color DayColor;
    private Color NightColor;
    // Start is called before the first frame update
    void Start()
    {
        panel = GetComponent<Image>();
        DayColor = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        NightColor = new Color(0.25f, 0.25f, 0.25f, 0.5f);
        Debug.Log(panel.color);
    }

    void ChangeLight(bool isDay) {
        if (isDay) {
            panel.color = NightColor;
        }
        else {
            panel.color = DayColor;
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
