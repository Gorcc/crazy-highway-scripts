using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public GameObject cookie1, cookie2, cookie3;
    public int randomNumber;
    void Start()
    {
        randomNumber = Random.Range(1, 4);
        if(randomNumber == 1)
        {
            cookie1.SetActive(true);
            cookie2.SetActive(false);
            cookie3.SetActive(false);
        }
        if (randomNumber == 2)
        {
            cookie1.SetActive(false);
            cookie2.SetActive(true);
            cookie3.SetActive(false);
        }
        if (randomNumber == 3)
        {
            cookie3.SetActive(true);
            cookie2.SetActive(false);
            cookie1.SetActive(false);
        }

       
    }

    
}
