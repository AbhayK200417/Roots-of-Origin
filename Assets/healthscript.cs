using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class healthscript : MonoBehaviour
{  
     public Slider healthbar;
    //  [SerializeField] private float _maxhealth;
    // [SerializeField] private HealthBar _healthbar;
    public float health = 100;
   
    public float damage = 10;
void Start()
{
    healthbar.value=100;
}
   void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            health -= damage;
             healthbar.value= health;
            // _healthbar.UpdateHealthBar(_maxhealth,health);
            Debug.Log(health);
            Destroy(collision.gameObject);
        }
    }
}