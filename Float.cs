using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float multforce = 350;
    public float degrees = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1.0f;
    Vector3 posOffset;
    Vector3 tempPos;


    private Rigidbody rb;


    void Start()
    {
        posOffset = transform.position;
       
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
   
    }


    void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degrees, 0f), Space.World);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;

       
    }


}
