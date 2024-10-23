using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveCheck : MonoBehaviour
{
    private Animator m_Animator;
    
    public bool moving;

     //Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
   void Update()
   {
       
       if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
       {
           moving = false;

       }
       else
       {
           moving = true;

       }  
   }
}
