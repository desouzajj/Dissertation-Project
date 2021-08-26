using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleScore : MonoBehaviour
{
    public Transform particle;
    HealthSystem hp1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "waterbottle")
        {
            Audio.instance.TrashThrowAwayGOOD();
            Score.scoreValue += 1;
            Score2.scoreValue += 1;
            particle.GetComponent<ParticleSystem>().Play(true);
        }

        if (collision.gameObject.tag == "Trashbag")
        {
            Audio.instance.TrashThrowAwayBAD();
            HealthSystem.health -= 1;

        }
        
    }
}
