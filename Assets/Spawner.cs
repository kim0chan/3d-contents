using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    int lr = 1;
    public float interval = 3.0f;
    public float endgame_interval = 1.0f;
    public float obstacleSpeed = 12.0f;
    public float endgame_obstacleSpeed = 24.0f;
    float pivot = 7.0f;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= interval)
        {
            float spawn_point = pivot + Random.Range(-pivot + 3.0f - interval, 4.0f);
            GameObject newObstacle = Instantiate(obstacle[(lr + 1) / 2], new Vector3(spawn_point * lr, 0.5f, -40), this.transform.rotation);
            Obstacle obstacleScript = newObstacle.GetComponent<Obstacle>();
            obstacleScript.speed = obstacleSpeed;
            
            timer = 0.0f;
            lr *= -1;
        }

        timer += Time.deltaTime;
        interval = Mathf.Lerp(interval, endgame_interval, Time.deltaTime * 0.01f);
        obstacleSpeed = Mathf.Lerp(obstacleSpeed, endgame_obstacleSpeed, Time.deltaTime * 0.01f);
        //test
    }
}
