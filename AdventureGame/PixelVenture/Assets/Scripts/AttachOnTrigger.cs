using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
     public void OnTriggerEnter(Collider other)
     {
         transform.parent = other.transform;
     }

    // Update is called once per frame
    public void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
