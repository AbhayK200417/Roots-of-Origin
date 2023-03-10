using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class healthscript : MonoBehaviour
{  
     public Slider healthbar;
     public int lives =4;
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
        
 if(collision.gameObject.tag == "NightGate")
 {
     SceneManager.LoadScene("Scenes/DesertScene");
 }
 if(collision.gameObject.tag == "DesertGate")
 {
 SceneManager.LoadScene("Scenes/IceScene");
 }
 if(collision.gameObject.tag == "IceGate")
 {
    SceneManager.LoadScene("Scenes/IceScene");
 }
 if(collision.gameObject.tag == "ForestGate")
 {
 SceneManager.LoadScene("Scenes/Forest Scene");
 }
        if (collision.gameObject.tag == "Ded")
        {
            if (SceneManager.GetActiveScene().name == "NightScene")
            {

                SceneManager.LoadScene("CityLost");
            }
            else if (SceneManager.GetActiveScene().name == "Scenes/IceScene")
            {
                SceneManager.LoadScene("IceLost");
            }
            else if (SceneManager.GetActiveScene().name == "Scenes/Forest Scene")
            {
                SceneManager.LoadScene("ForestLost");
            }
            else if (SceneManager.GetActiveScene().name == "Scenes/DesertScene")
            {
                SceneManager.LoadScene("DesertLost");
            }
        }




        if (collision.gameObject.tag == "enemy")
        {
            health -= damage;
             healthbar.value= health;
             if(health==0)
             {
                lives--;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                health=100;
            if(lives==0)
            {
                if(SceneManager.GetActiveScene().name=="NightScene")
                {

                SceneManager.LoadScene("CityLost");
                }
                else if (SceneManager.GetActiveScene().name=="")
                {
                    SceneManager.LoadScene("IceLost");
                }
                else if (SceneManager.GetActiveScene().name=="")
                {
                    SceneManager.LoadScene("ForestLost");
                }
                else if (SceneManager.GetActiveScene().name=="")
                {
                    SceneManager.LoadScene("DesertLost");
                }
            }
            Debug.Log("Number of lives left = " + lives);
             }
            // _healthbar.UpdateHealthBar(_maxhealth,health);
            Debug.Log(health);
            Destroy(collision.gameObject);
        }
    }
}