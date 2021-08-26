using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Drag : MonoBehaviour
{
    public Transform target, target1;
    private Vector3 mOffset;
    private float mZCoord;
    Rigidbody rb;
    private void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        if (gameObject != null)
        {
            Audio.instance.TrashPickUp();
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

            mOffset = gameObject.transform.position - GetMouseWorldPos();

            gameObject.GetComponent<Outline>().enabled = true;
            //rb.constraints = RigidbodyConstraints.None;
        }
    }


    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }


    void OnMouseDrag()
    {
        if (gameObject != null)
        {
            transform.position = GetMouseWorldPos() + mOffset;
        }
    }

    IEnumerator OnMouseUp()
    {
        target1 = GameObject.FindGameObjectWithTag("recyclescore").transform;
        target = GameObject.FindGameObjectWithTag("trashscore").transform;
        if (gameObject != null)
        {
            if (gameObject.transform.position.x > 21)
            {
                yield return new WaitForSeconds(0.1f);
                transform.DOJump(target.position, 30f, 2, 5f);
            }
            if (gameObject.transform.position.x < -46)
            {
                yield return new WaitForSeconds(0.1f);
                transform.DOJump(target1.position, 30f, 2, 5f);
            }
        }
    }

}
