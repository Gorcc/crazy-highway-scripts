using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float timecount;
    
    void Start()
    {
        timecount = 0;

       
        
    }
    void Update()
    {
        timecount = Time.timeSinceLevelLoad;
        if (timecount >= 6)
        {
            MovetheCar();
        }

    }
    // Update is called once per frame
    void MovetheCar()
    {
        transform.position += transform.forward * 25 * Time.deltaTime;
    }
}
