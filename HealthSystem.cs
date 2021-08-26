using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthSystem : MonoBehaviour
{
    public static int health = 3;
    public int numofhearts;

    public Image[] hearts;

    public Sprite fullheart;
    public Sprite halfheart;
    public Sprite emptyheart;
    public Gameover Gameover;

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
     void Update()
    {

        if(health > numofhearts)
        {
            health = numofhearts;
        }
        
        for(int i =0; i < numofhearts; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullheart;
            }  else { hearts[i].sprite = emptyheart; }

            if( i < numofhearts)
            {
                hearts[i].enabled = true;
            }  else { hearts[i].enabled = false; }          
        }
        //if (Score.scoreValue == -1)
        //{
        //    health = 2;
        //}
        //if (Score.scoreValue == -2)
        //{
        //    health = 1;
        //}
        if (health == 0)
        {
           // health = 0;
            Gameover.gameObject.SetActive(true);
            PauseGame();

        }
        
    }
    public void RestartButton()
    {
        // Gameover1.gameObject.SetActive(false);
        // DontDestroyOnLoad(Gameover1);
        Time.timeScale = 1;
        Gameover.gameObject.SetActive(false);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        health = 3;
        //Time.timeScale = 1;
        // SceneManager.LoadScene(1);
    }

}
