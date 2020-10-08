using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlay : MonoBehaviour
{
    public float speed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");
       transform.Traslate(x * speed, 0.0f, z * speed);
    }
}
