using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

  public GameObject Rotateobj;
  
  private void OnTriggerEnter(Collider other)
  {
    Rotateobj.transfoerm.RotateAround(new Vector3(1.45f, 0.0f, 5.6f), Vector3.up, 90);
  }
  
  private void OnTriggerExit(zcollider other)
  {
    RotateOZbj.transform.RotateAround(new Vector3(1.45f, 0.0f, 5.6f), Vector3.up, -90);
  
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
