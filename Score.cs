using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform car;
    public Text scoreText;
    public double scoreupdate;

    // Update is called once per frame
    void Update()
    {
        scoreupdate = car.position.z * 1.5;
        scoreText.text = "SCORE\n" + scoreupdate.ToString("0");
    }
}
