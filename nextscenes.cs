using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextscenes : MonoBehaviour
{
    public void mountainbutton()
    {
        SceneManager.LoadScene(3);
    }
    public void citybutton()
    {
        SceneManager.LoadScene(1);
    }
    public void citnynightbutton()
    {
        SceneManager.LoadScene(2);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
        Audio.instance.mainMenu();
    }
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("game is quitting");
    }
}
