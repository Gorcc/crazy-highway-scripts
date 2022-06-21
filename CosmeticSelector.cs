using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CosmeticSelector : MonoBehaviour
{
    public static int currentCarIndex;
    public GameObject[] carModels;
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    public CarSelection carselection;
    // Cosm 1
    public int Cosmetic1bought;
    public GameObject Cosmetic1UI;
    public static int Buy1Check;
    public static int Buy2Check;
    public static int Buy3Check;
    public static int Buy4Check;
    // Cosm 2
    private int Cosmetic2bought = 0;
    public GameObject Cosmetic2UI;

    // Cosm 3
    private int Cosmetic3bought = 0;
    public GameObject Cosmetic3UI;

    // Cosm 4
    private int Cosmetic4bought = 0;
    public GameObject Cosmetic4UI;


    void Start()
    {
        

        Buy1Check = PlayerPrefs.GetInt("Cosmetic1");
        Buy2Check = PlayerPrefs.GetInt("Cosmetic2");
        Buy3Check = PlayerPrefs.GetInt("Cosmetic3");
        Buy4Check = PlayerPrefs.GetInt("Cosmetic4");



        if (Buy1Check == 1)
        {
            Cosmetic1UI.SetActive(false);

        }
        if (Buy2Check == 1)
        {
            Cosmetic2UI.SetActive(false);

        }
        if (Buy3Check == 1)
        {
            Cosmetic3UI.SetActive(false);

        }
        if (Buy4Check == 1)
        {
            Cosmetic4UI.SetActive(false);

        }



        currentCarIndex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in carModels)
            car.SetActive(false);

        carModels[currentCarIndex].SetActive(true);
    }


    void Update()
    {
        
        
        


    }

    public void BuyCosmetic1()
    {
        if(CarSelection.PocketMoney > 250)
        {
            
                CarSelection.PocketMoney -= 250;
                Cosmetic1bought += 1;
                Cosmetic1UI.SetActive(false);
                PlayerPrefs.SetInt("Cosmetic1", Cosmetic1bought);
                PlayerPrefs.SetFloat("PocketMoney", CarSelection.PocketMoney);
            
           

        }
        

    }
    public void BuyCosmetic2()
    {
        if (CarSelection.PocketMoney > 15000)
        {

            CarSelection.PocketMoney -= 15000;
            PlayerPrefs.SetFloat("PocketMoney", CarSelection.PocketMoney);
            Cosmetic2bought += 1;
            Cosmetic2UI.SetActive(false);
            PlayerPrefs.SetInt("Cosmetic2", Cosmetic2bought);




        }

    }
    public void BuyCosmetic3()
    {
        if (CarSelection.PocketMoney > 25000)
        {

            CarSelection.PocketMoney -= 25000;
            PlayerPrefs.SetFloat("PocketMoney", CarSelection.PocketMoney);
            Cosmetic3bought += 1;
            Cosmetic3UI.SetActive(false);
            PlayerPrefs.SetInt("Cosmetic3", Cosmetic3bought);




        }
    }
    public void BuyCosmetic4()
    {
        if (CarSelection.PocketMoney > 10000)
        {

            CarSelection.PocketMoney -= 10000;
            PlayerPrefs.SetFloat("PocketMoney", CarSelection.PocketMoney);
            Cosmetic4bought += 1;
            Cosmetic4UI.SetActive(false);
            PlayerPrefs.SetInt("Cosmetic4", Cosmetic4bought);




        }
    }

    public void ChangeNext()
    {
        carModels[currentCarIndex].SetActive(false);

        currentCarIndex++;
        if (currentCarIndex == carModels.Length)
            currentCarIndex = 0;

        carModels[currentCarIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", currentCarIndex);
    }

    public void ChangePrevious()
    {
        carModels[currentCarIndex].SetActive(false);

        currentCarIndex--;
        if (currentCarIndex < 0)
            currentCarIndex = carModels.Length - 1;

        carModels[currentCarIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", currentCarIndex);
    }




}

