using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodGroup : MonoBehaviour
{
    public float speed = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
