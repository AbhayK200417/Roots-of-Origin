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












}
