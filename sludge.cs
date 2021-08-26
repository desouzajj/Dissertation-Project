using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sludge : MonoBehaviour
{
    public Transform sludgeParticle;
   // public float starttime = 15;
    public float delaytime;// = Random.Range(15, 45);
    void Start()
    {
        delaytime = Random.Range(4, 8);
        //StartCoroutine(startsludge());
        // sludgeParticle.GetComponent<ParticleSystem>().Stop();
        Audio.instance.lvl1audio();
    }
    
    void OnMouseDown()
    {
        delaytime = Random.Range(4, 8);
      //  Debug.Log("read me");
        sludgeParticle.GetComponent<ParticleSystem>().Stop();
        StartCoroutine(startsludge());
    }
     void Update()
    {
        
    }

    void sludgescore()
    {
        if (sludgeParticle.GetComponent<ParticleSystem>().isPlaying == true && Score.scoreValue > 0)
        {
            Score.scoreValue -= 1;
        }
    }
    IEnumerator startsludge()
    {
        yield return new WaitForSeconds(delaytime);
               
            sludgeParticle.GetComponent<ParticleSystem>().Play(true);
        sludgescore();
    }
}
