using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMoney : MonoBehaviour
{
    public Text GameOverMoney1;
    public float GameOverMoney2;
    private Deleteprops moeny;
    private Money money;

    void Update()
    {
        GameOverMoney2 = Deleteprops.extraMoney + Money.score;
        GameOverMoney1.text = GameOverMoney2.ToString("n2") + " $";
    }
}
