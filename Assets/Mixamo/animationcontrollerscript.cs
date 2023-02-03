using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]

public class animationcontrollerscript : MonoBehaviour
{
    private Animator myAnim;
    private Rigidbody rigidbdy;
    private static float Speed=3f;
    private bool running;
    private bool isJumping;
    private float horizontalinput;
    public GameObject gameObject;
      public float jumpforce = 1f;


   
    // Start is called before the first frame update
    void Start()
    {
        myAnim=GetComponent<Animator>();
        rigidbdy=GetComponent<Rigidbody>();
        running=false;
        isJumping=false;
    }

    // Update is called once per frame
    void Update()
    {
        // isrunning=Input.GetKey(KeyCode.W);
        // isJumping=Input.GetKey(KeyCode.Space);

        // myAnim.SetBool("isrunning",isrunning);
        // myAnim.SetBool("isjumping",isJumping);



        horizontalinput=Input.GetAxis("Horizontal");
        if(Mathf.Abs(horizontalinput)>0.01f)
        {
            transform.rotation=Quaternion.LookRotation(new Vector3(horizontalinput,0f,0f));
            rigidbdy.MovePosition(rigidbdy.position+transform.forward*Speed*0.01f);
            if(!running)
            {
                running=true;
                myAnim.SetBool("isrunning",true);
            }
        }
        else if (running)
        {
            running=false;
            myAnim.SetBool("isrunning",false);
        }
        if(Input.GetKey(KeyCode.Space))
        {
             myAnim.SetBool("isjumping",true);
            //  if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbdy.AddForce(Vector3.up * jumpforce);
                
            }
             
        }else{
             myAnim.SetBool("isjumping",false);
        }









        // if (Input.GetKey("right"))
        // {
        //    myAnimo.SetBool("isrunning",true);
        // }else
        // {
        //      myAnimo.SetBool("isrunning",false);
        // }

        // if (Input.GetKey("up"))
        // {
        //   myAnimo.SetBool("isjumping",true);
        // }else
        // {
        //       myAnimo.SetBool("isjumping",false);
        // }

    }
}
