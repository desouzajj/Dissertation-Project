using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    //public GameObject trashobject;
    //public Transform[] spawnPoints;
    //public float min = .1f;
    //public float max = 5f;

    // void Start()
    //{
    //    StartCoroutine(spawn()); 
    //}

    //IEnumerator spawn()
    //{
    //    while (true)
    //    {
    //        float delay = Random.Range(min, max);

    //        yield return new WaitForSeconds(delay);
    //        int spawnIndex = Random.Range(0, spawnPoints.Length);
    //        Transform spawnPoint = spawnPoints[spawnIndex];

    //        Instantiate(trashobject, spawnPoint.position, spawnPoint.rotation);
    //    }
    //}
    ////////////////
    public GameObject _object;
    // public GameObject object1;
    private float timebtwspawn;
    public float starttimespawn;


    public static SpawnItems instance;
    void Awake()
    {
        instance = this;
    }
    void Update()
    {

        if (timebtwspawn <= 0)
        {
            Instantiate(_object, transform.position, Quaternion.identity);
            //Instantiate(object1, transform.position, Quaternion.identity);
            timebtwspawn = starttimespawn;
        }
        else
        {
            timebtwspawn -= Time.deltaTime;
        }
        subtime();
    }
    public void subtime()
    {
        starttimespawn -= 0.005f * Time.deltaTime;
    }


    ///////////////
    //public GameObject spawnobject;
    //public bool stopspawn = false;
    //public float spawntime;
    //public float spawndelay;

    //void Start()
    //{
    //    InvokeRepeating("SpawnObject",spawntime, spawndelay);
    //}

    //public void SpawnObject()
    //{
    //    Instantiate(spawnobject, transform.position, transform.rotation);
    //    if (stopspawn)
    //    {
    //        CancelInvoke("SpawnObject");
    //    }
    //}
}
