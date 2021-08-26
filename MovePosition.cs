using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MovePosition : MonoBehaviour
{
    
    public float multforce = 100;

    public float speed;

    private void Update()
    {
        
        if (gameObject != null)
        {
            float y = Mathf.Lerp(-0.1f, 10, 30) * speed;
            transform.position += new Vector3(0, y, 1 * Time.deltaTime * -multforce);
        }

    }
    
    
   
}
