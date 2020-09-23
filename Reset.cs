using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Keycode.Space))
        {
            transform.position = new Vector3(0.0f, 3.0f, 0.0f);
            // params of Vector3 are the point of respawn
        }
    }
}
