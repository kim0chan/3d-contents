using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                Application.Quit();
            }
            else {
                SceneManager.LoadScene("GameScene");
            }
        }
        if (Time.time > 60.0f) {
            SceneManager.LoadScene("GameScene");
        }
    }
}
