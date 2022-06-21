using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject startercar;
    public static float PocketMoney = 999999;
    private Money bankaccount;
    public Text bankacc;
    


    // LEXUS TEXTS
    public GameObject car2price;
    public GameObject lexusSelect;
    public GameObject lexusSelecttext;
    public GameObject lexusSelected;
    public bool lexusBought;
    public bool isSelected = false;

    //
    
    
    

    // Update is called once per frame
    void Update()
    {
        
        bankacc.text = PocketMoney.ToString("n2")+" $";
    }

    // Show cars in store screen
    public void ShowStartercar()
    {
        startercar.SetActive(true);
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(false);
    }


    public void ShowCar1()
    {
        startercar.SetActive(false);
        car1.SetActive(true);
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(false);
    }
    public void ShowCar2()
    {
        startercar.SetActive(false);
        car1.SetActive(false);
        car2.SetActive(true);
        car3.SetActive(false);
        car4.SetActive(false);
    }
    public void ShowCar3()
    {
        startercar.SetActive(false);
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(true);
        car4.SetActive(false);
    }
    public void ShowCar4()
    {
        startercar.SetActive(false);
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(true);
    }

    public void BuyCar2()
    {
        car2price.SetActive(false);
        lexusSelect.SetActive(true);
        if (lexusBought == false)
        {

            PocketMoney -= 2500;
            lexusBought = true;
            lexusSelecttext.SetActive(true);


        }


    }
    public void SelectCar2() { 
    if (lexusBought == true && isSelected == false)
     {
            ShowCar2();
            lexusSelect.SetActive(false);
            lexusSelected.SetActive(true);
            isSelected = true;
            if( isSelected == true)
            {
                lexusSelect.SetActive(false);
            }

            }
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
