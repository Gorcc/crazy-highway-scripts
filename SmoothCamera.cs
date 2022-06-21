using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public Transform look;
    public Transform look2;

    private Deleteprops deleteprops;
    public int deneme;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    public bool CarDead = false;
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity ,smoothSpeed);

        transform.position = smoothedPosition;

        if(Deleteprops.caralive == true)
        {
            transform.LookAt(look);
        }
        if(Deleteprops.caralive == false)
        {
            transform.LookAt(look2);
        }



    }
}
