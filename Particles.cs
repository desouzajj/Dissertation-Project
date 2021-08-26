using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Particles : MonoBehaviour
{
    
    public Text points;

    void Start()
    {
        points = GetComponent<Text>();
    }

  
    void Update()
    {
        points.text = Score.scoreValue + " POINTS";
    }
}
