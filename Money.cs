using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static float score;
    public Transform Car;
    public Text taximeter;
    
    public static float bankaccount;
    public static int scoretaker;
    public float scoremultiplier = 1.5f;


    // Update is called once per frame
    void Update()
    {
         score = Car.position.z / 100;
        taximeter.text = score.ToString("n2") + " $";
       
        bankaccount = score;

        
        
    }

    
}
