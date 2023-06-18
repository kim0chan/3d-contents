using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 8.8f) {
            SceneManager.LoadScene("TitleScene");
        }
        if (Input.anyKeyDown) {
            if (Application.platform == RuntimePlatform.WindowsPlayer) {
                if (Input.GetKeyDown(KeyCode.Escape)) {
                    Application.Quit();
                }
                else {
                SceneManager.LoadScene("TitleScene");
                }
            }
        }
    }
}
