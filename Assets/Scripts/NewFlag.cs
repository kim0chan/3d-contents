using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFlag : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.name == "Player") {
            GetComponent<Animator>().SetBool("isHit", true);
            // Debug.Log("animation gogo!");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
