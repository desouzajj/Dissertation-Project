using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject != null)
        {
            if (collision.gameObject.tag == "trashscore")
            {
                Destroy(gameObject);
            }
            if (collision.gameObject.tag == "recyclescore")
            {
                Destroy(gameObject);
            }
            if (collision.gameObject.tag == "Sidewalk")
            {
                HealthSystem.health -= 1;
                // Score.scoreValue -= 1;
                Destroy(gameObject);
            }
        }
    }

}
