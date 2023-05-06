using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Obstacle Section
    public GameObject[] obstacle;
    int lr = 1;
    public float interval = 3.0f;
    public float endgame_interval = 1.0f;
    public float obstacleSpeed = 12.0f;
    public float endgame_obstacleSpeed = 24.0f;
    public float spawn_point;
    public float prev_spawn_point;
    float pivot = 7.0f;
    float timer = 0.0f;

    // Star Section
    public GameObject[] star;
    public float Star_Prob = 9.0f;
    public int Star_interval = 5;
    public int Star_timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= interval)
        {
            spawn_point = pivot + Random.Range(-pivot + 3.0f - interval, 4.0f);
            prev_spawn_point = spawn_point * lr;
            GameObject newObstacle = Instantiate(obstacle[(lr + 1) / 2], new Vector3(prev_spawn_point, 0.5f, -40), this.transform.rotation);
            Obstacle obstacleScript = newObstacle.GetComponent<Obstacle>();
            obstacleScript.speed = obstacleSpeed;
            
            timer = 0.0f;
            Star_timer++;
            lr *= -1;
        }

        if(2 * timer >= interval) {
            if(Star_timer > Star_interval) {
                float prob = Random.Range(0.0f, 10.0f);
                if(prob < Star_Prob) {
                    float star_spawn_point = Random.Range(-12.0f, 12.0f);
                    GameObject newObstacle = Instantiate(star[0], new Vector3(prev_spawn_point * 0.3f, 0.5f, -40), this.transform.rotation);
                    Obstacle obstacleScript = newObstacle.GetComponent<Obstacle>();
                    obstacleScript.speed = obstacleSpeed;
                    Star_timer = 0;
                }                
            }
        }

        timer += Time.deltaTime;
        interval = Mathf.Lerp(interval, endgame_interval, Time.deltaTime * 0.01f);
        obstacleSpeed = Mathf.Lerp(obstacleSpeed, endgame_obstacleSpeed, Time.deltaTime * 0.01f);
        //test
    }
}
