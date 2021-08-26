using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changewater : MonoBehaviour
{
    [SerializeField] private Material material1;
    private void OnCollisionEnter(Collision collision)
    { 

        if(collision.gameObject.tag == "Trashbag")
        {
            material1.color = Color.Lerp(Color.blue, Color.grey, 5.0f);
        }
    }

}
