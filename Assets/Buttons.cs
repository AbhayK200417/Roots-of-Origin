using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private string input;
    public void ContinueButton()
    {
        SceneManager.LoadScene("NightScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("s1");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("NightScene");
    }
    
    public void Quit()
    {
        SceneManager.LoadScene("NtScene");
    }
    public void AnswerString(string s)
{
   input=s;
   
   if (input=="FIRE"||input=="fire"||input=="Fire")
   {
        SceneManager.LoadScene("s1");
   }

}
    public void AnswerIce(string s1)
{
 
   
   if (s1=="WATER"||s1=="Water"||s1=="water")
   {
        SceneManager.LoadScene("s1");
   }

}
    public void AnswerWind(string s1)
{
 
   
   if (s1=="Wind"||s1=="wind"||s1=="WIND")
   {
        SceneManager.LoadScene("s1");
   }

}












}
