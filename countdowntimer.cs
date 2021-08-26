using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class countdowntimer : MonoBehaviour
{
    public float timer = 3.0f;
    public TextMeshProUGUI time;
   
    
    void Start()
    {
        Debug.Log("void start");
        time = GetComponent<TextMeshProUGUI>();
       StartCoroutine(countdown());
       
    }

    IEnumerator countdown()
    {
        Debug.Log("IEnumerator");
        GameObject varGameObject = GameObject.Find("WaterbottleSpawner 1");
        GameObject varGameObject1 = GameObject.Find("WaterbottleSpawner 2");
        GameObject varGameObject2 = GameObject.Find("WaterbottleSpawner 3");
        GameObject varGameObject3 = GameObject.Find("WaterbottleSpawner 4");
        while (timer > 0)
        {
            time.text = timer.ToString();
            yield return new WaitForSeconds(1f);
            timer--;
           
        }
        varGameObject.GetComponent<SpawnItems>().enabled = true;
        varGameObject1.GetComponent<SpawnItems>().enabled = true;
        varGameObject2.GetComponent<SpawnItems>().enabled = true;
        varGameObject3.GetComponent<SpawnItems>().enabled = true;
        time.text = "START";
        GetComponent<TextMeshProUGUI>().color = Color.green;
        yield return new WaitForSeconds(1f);
        time.gameObject.SetActive(false);
    }
}
