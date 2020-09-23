using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePlay : MonoBehaviour
{

  public GameObject viewcamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float mouse_x = Input.GetAxis("Mouse X");
       float mouse_y = Input.GetAxis("Mouse Y");
       transform.Rotate(0.0f, mouse_x, 0.0f);
       viewcamera.transform.Rotate(-mouse_y, 0.0f, 0.0f);
    }
}
