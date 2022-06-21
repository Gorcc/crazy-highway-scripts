using UnityEngine.UI;
using UnityEngine;

public class extraMoney : MonoBehaviour
{
    public Text extramoney;
    private Deleteprops moeny;

    void Update()
    {
        extramoney.text = Deleteprops.extraMoney.ToString("n2") + " $";
    }
}
