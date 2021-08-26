using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score2 : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score2;
    public Levelcomplete2 load;

    void Start()
    {
        score2 = GetComponent<TextMeshProUGUI>();

    }


    void Update()
    {
        score2.text = "Trash Items: " + scoreValue;// + "/30";
        //if (scoreValue >= 30)
        //{
        //    load.lvl();
        //}
    }

}
