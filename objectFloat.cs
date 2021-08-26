using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFloat : MonoBehaviour
{

    public float multforce = 350;
    public float amplitude = 0.5f;
    public float frequency = 1.0f;
   // Vector3 posOffset = new Vector3();
    //Vector3 tempPos = new Vector3();
    Vector3 posOffset;
    Vector3 tempPos;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;


        transform.position = tempPos;

        rb.AddForce(transform.forward * multforce * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<objectFloat>().enabled = false;
    }
}
