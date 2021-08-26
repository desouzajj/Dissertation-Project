using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Gameover : MonoBehaviour
{
    public TextMeshProUGUI pointstext;
    public Gameover Gameover1;
    HealthSystem hp;
    


    public void Setup(int score)
    {
        gameObject.SetActive(true);
       
       // pointstext.text = Score.scoreValue + " POINTS";
      
    }
    // void Update()
    //{
    //    if (hp.health == -3)
    //    {
    //        gameObject.SetActive(true);

    //    }
    //}

    public void RestartButton()
    {
        // Gameover1.gameObject.SetActive(false);
       // DontDestroyOnLoad(Gameover1);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        
       // SceneManager.LoadScene(1);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
