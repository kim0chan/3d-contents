using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    int lr = 1;
    double interval = 3.0f;
    double timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= interval)
        {
            Instantiate(obstacle[(lr + 1) / 2], new Vector3(Random.Range(-11, 11), 0.5f, -40), this.transform.rotation);
            timer = 0.0f;
            lr *= -1;
        }

        timer += Time.deltaTime;
    }
}
