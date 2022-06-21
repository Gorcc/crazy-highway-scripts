using UnityEngine.UI;
using UnityEngine;

public class Rageslider : MonoBehaviour
{
    private Image RageBar;
    public float CurrentRage;
    private float MaxRage =100f;
    public Deleteprops rage;



    private void Start()
    {
        RageBar = GetComponent<Image>();

    }


    private void Update()
    {

        CurrentRage = Deleteprops.rage;
        RageBar.fillAmount = CurrentRage / MaxRage;
    }
}
