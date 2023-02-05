using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMagic : MonoBehaviour
{
    public GameObject foam;
    public static GameObject instFoam;
    public float speed = 50f;
    public Transform target;
    public float radi =10f;
    private Vector3 pos;
    public float delay = 1f;
    float timer;
    public static bool righface = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

        
     
    private void Update()
    {
        pos = target.position - transform.position;
        timer += Time.deltaTime;
        if (timer > delay)
        {
            if (pos.magnitude <= radi)
            {
                ShootBall();
            }
                timer -= delay;
        }
        if (pos.x < 0)
        {
            righface = true;
           
        }
        else
        {
            righface = false;
            
        }
       




    }
    /* private void OnTriggerEnter(Collider other)
     {
         GameObject instFoam = Instantiate(foam, transform.position, Quaternion.identity);
         Rigidbody instFoamRB = instFoam.GetComponent<Rigidbody>();
         Vector3 dir = new Vector3(0, -2, 0);
         instFoamRB.AddForce((target.position - dir) * speed);
     }
    */
   private void ShootBall()
    {
       


        // Debug.Log(pos.magnitude);
        Debug.Log(radi);

            
        Debug.Log("working");
           instFoam = Instantiate(foam, transform.position, Quaternion.identity);
            Rigidbody instFoamRB = instFoam.GetComponent<Rigidbody>();
            // instFoam.transform.position += Vector3.right * Time.deltaTime * speed;
            //transform.position = Vector3.MoveTowards(instFoam.transform.position, target.position, 5f);

            instFoamRB.AddForce((target.position) * 4000f);
            Destroy(instFoam, 3f);
     
        
    }
    public static void DestroyFoam(GameObject instFoam)
    {
           Destroy(instFoam);
    }
    
}

