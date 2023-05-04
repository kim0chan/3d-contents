using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float EPS = 0.01f;

    public float moveDir = 1.0f;    // �̵� ���� ����, 1�� �� ����, -1�� �� �������� �̵�
    public float currentDir = 1.0f; // ���� �̵� �ӵ��� ��Ʈ���ϴ� ����
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
        // ���� ���� ���� 0 ~ 1 ������ �����Ͽ� ���� ������ ���
        interpolation = (currentDir + 1) / 2;

        /// Ű ��ǲ �޾Ƽ� ó��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isChangingDir)
            {
                moveDir *= -1;
                isChangingDir = true;
            }
        }

        /// ���� ��ȯ ó��
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
        /// ���� ��ȯ �� �Ͼ �� �ִ� ���� ó��(Ŭ����)
        if(currentDir < -1.01f)
        {
            currentDir = -1.0f;
        }
        if(currentDir > 1.01f)
        {
            currentDir = 1.0f;
        }


        /// �÷��̾� �̵�
        this.transform.position += Vector3.Lerp(dirLeft, dirRight, interpolation) * moveSpeed * Time.deltaTime;
    }
}
