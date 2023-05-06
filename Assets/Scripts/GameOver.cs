using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //public GameObject GameOverText;
    // Start is called before the first frame update

    public void OnCollisionEnter(Collision collision)
    {
        //GameOverText.SetActive(true);    
    }

    void Start()
    {
        //GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
