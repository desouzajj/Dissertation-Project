using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    public Levelcomplete finish;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {
        score.text = "Trash Items: " + scoreValue;// + "/15";
        //if (scoreValue >= 15)
        //{
        //    finish.lvl();
        //}
    }
   

}
