using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DarkMagic.righface == true)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(1f, 0f, 0f));
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(-1f, 0f, 0f));
        }
    }
}
