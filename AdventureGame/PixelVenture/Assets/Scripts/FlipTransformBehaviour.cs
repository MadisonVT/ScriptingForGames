using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    public KeyCode key1 = KeyCode.RightArrow, key2 = KeyCode.LeftArrow;

    public float direction1 = 0, direction2 = 180;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);
        }

        if (!Input.GetKeyDown(key2)) return;
        transform.rotation = Quaternion.Euler(0, direction2, 0);
    }
}
