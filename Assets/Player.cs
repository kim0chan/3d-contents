using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float EPS = 0.01f;

    public float moveDir = 1.0f;    // 이동 방향 설정, 1일 시 우측, -1일 시 좌측으로 이동
    public float currentDir = 1.0f; // 현재 이동 속도를 컨트롤하는 변수
    public float interpolation = 1.0f;
    public bool isChangingDir = false;
    public float moveSpeed = 6f;
    public float dirChangeSpeed = 2f;

    public Vector3 dirRight = new Vector3(1f, 0, 0);
    public Vector3 dirLeft = new Vector3(-1f, 0, 0);
    public float rotRight = -30f, rotLeft = 30f;
    float ABS(float a)
    {
        if (a < 0) return -a;
        return a;
    }
    void Start()
    {
        this.transform.eulerAngles = new Vector3(0, -45f, 0);
    }

    void Update()
    {
        // 현재 방향 값을 0 ~ 1 값으로 매핑하여 보간 값으로 사용
        interpolation = (currentDir + 1) / 2;

        /// 키 인풋 받아서 처리
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isChangingDir)
            {
                moveDir *= -1;
                isChangingDir = true;
            }
        }

        /// 방향 전환 처리
        if (isChangingDir)
        {
            if(ABS(moveDir - currentDir) > EPS)
            {
                this.transform.eulerAngles = new Vector3(0, Mathf.Lerp(rotLeft, rotRight, interpolation), 0);
                currentDir += moveDir * dirChangeSpeed * Time.deltaTime;
            }
            else
            {
                currentDir = moveDir;
                isChangingDir = false;
            }
        }
        /// 방향 전환 중 일어날 수 있는 버그 처리(클램핑)
        if(currentDir < -1.01f)
        {
            currentDir = -1.0f;
        }
        if(currentDir > 1.01f)
        {
            currentDir = 1.0f;
        }


        /// 플레이어 이동
        this.transform.position += Vector3.Lerp(dirLeft, dirRight, interpolation) * moveSpeed * Time.deltaTime;
    }
}
