using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class waterball : MonoBehaviour
 {
     // Script should be attached to spawn point of foam rather than foam itself!!
     public GameObject foam;
     public float speed = 50f;
      public float delay = 1.4f;
      public int numbershoot;
    float timer;
 
     // Start is called before the first frame update
     void Start()
     {
 
     }
 
     // Update is called once per frame
     void Update()
     { 



        if(Input.GetKeyDown(KeyCode.S))
        {
numbershoot++;
        }
          if (Input.GetKeyUp(KeyCode.S))
          {
            timer=0;
          }
         if (Input.GetKey(KeyCode.S))
         {

         timer += Time.deltaTime;
        if (timer > delay&&numbershoot==1)
        {
                ShootSpell();  
                timer=0;     
                numbershoot=0;
        }
         }  
 
 
             
//  numbershoot=0;
     }
     private void ShootSpell()
     {
        GameObject instFoam = Instantiate(foam, transform.position, Quaternion.identity);
             
             Rigidbody instFoamRB = instFoam.GetComponent<Rigidbody>();
            // instFoam.transform.position += Vector3.right * Time.deltaTime * speed;
            instFoamRB.AddForce(Vector3.right*1000f);
 
            //  instFoamRB.AddForce(Vector3.forward * speed);
             Destroy(instFoam, 3f);
             timer=0;

             
     }
 }