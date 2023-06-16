using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    private Light directionalLight;
    private bool isDay = true;
    private Color DayColor;
    private Color NightColor;
    // Start is called before the first frame update
    void Start()
    {
        directionalLight = GetComponent<Light>();
        DayColor = new Color(1.0f, 1.0f, 1.0f);
        NightColor = new Color(0.16f, 0.20f, 0.30f);
    }

    void ChangeLight(bool isDay) {
        if (isDay) {
            directionalLight.color = NightColor;
        }
        else {
            directionalLight.color = DayColor;
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
