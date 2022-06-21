using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class CarSelection : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;

    public static float PocketMoney;
    public  float PocketMoney1;
    public float Money;
    private Money bankaccount;
    public Text bankacc;
    private int currentCar;
    public static int startupcar;
    public TimeManager timecounter;
    public GameObject CarHolder;
    public GameObject CosmeticHolder;
    public GameObject CosmeticButton1, CosmeticButton2;

    // First Car
    public static bool firstCarbought= false;
    public GameObject firstCar;
    public GameObject firstcarUIs;
    public static int car1bought;
    // Second Car
    public static bool secondCarbought;
    public GameObject secondCar;
    public GameObject secondcarUIs;
    public static int car2bought;
    // Third Car
    public static bool thirdCarbought;
    public GameObject thirdCar;
    public GameObject thirdcarUIs;
    public static int car3bought;
    // Fourth Car
    public static bool fourthCarbought;
    public GameObject fourthCar;
    public GameObject fourthcarUIs;
    public static int car4bought;

    // Fifth Car
    public static bool fifthCarbought;
    public GameObject fifthCar;
    public GameObject fifthcarUIs;
    public static int car5bought;
    //

    // Cosmetic 1
    public bool cosmetic1Carbought;
    public GameObject cosmetic1Car;
    public GameObject cosmetic1UIs;
    public static int cosmetic1bought;

    public void Start()
    {
        
        
        CosmeticButton1.SetActive(false);
        CosmeticButton2.SetActive(false);

        
        PocketMoney =PlayerPrefs.GetFloat("PocketMoney");
        
        
        SelectCar(PlayerPrefs.GetInt("startupcar"));

        if (PlayerPrefs.GetInt("BuyFirstCar") != 0 != false)
        {
            firstCar.SetActive(false);
            firstcarUIs.SetActive(false);

        }
        if (PlayerPrefs.GetInt("BuySecondCar") != 0 != false)
        {
            secondCar.SetActive(false);
            secondcarUIs.SetActive(false);

        }
        if (PlayerPrefs.GetInt("BuyThirdCar") != 0 != false)
        {
            thirdCar.SetActive(false);
            thirdcarUIs.SetActive(false);

        }
        if (PlayerPrefs.GetInt("BuyFourthCar") != 0 != false)
        {
            fourthCar.SetActive(false);
            fourthcarUIs.SetActive(false);

        }
        if (PlayerPrefs.GetInt("BuyComsetic1") != 0 != false)
        {
           cosmetic1Car.SetActive(false);
            cosmetic1UIs.SetActive(false);

        }



    }
    
    public void Update()
    {
      
        

        bankacc.text = PocketMoney.ToString("n2") + " $";
       

        
        if(startupcar < 0)
        {
            startupcar = 0;
            SelectCar(0);
        }
    }

    private void SelectCar(int _index)
    {
        PlayerPrefs.SetInt("index", _index);
        previousButton.interactable = (PlayerPrefs.GetInt("index") != 0);
        nextButton.interactable = (PlayerPrefs.GetInt("index") != transform.childCount - 1);
        for(int i=0; i < transform.childCount; i++)
        {
           
            transform.GetChild(i).gameObject.SetActive(i == PlayerPrefs.GetInt("index"));
            
            startupcar = _index;
            PlayerPrefs.SetInt("startupcar", startupcar);

           
           
        }
    }

    public void ChangeCar(int _change)
    {
        
        currentCar += _change ;
        SelectCar(currentCar);


    }
    // BUYING CARS ////////////////////////
    public void BuyCar1()
    {
        // Mazda
        if (PocketMoney > 2500)
        {
            PocketMoney -= 2500;
            firstCarbought = true;
            car1bought = 1;

            PlayerPrefs.SetFloat("PocketMoney", PocketMoney);

            PlayerPrefs.SetInt("BuyFirstCar", (firstCarbought ? 1 : 0));
            firstCarbought = (PlayerPrefs.GetInt("BuyFirstCar") != 0);
            
        }


        if (firstCarbought == true)
        {
            firstCar.SetActive(false);
            firstcarUIs.SetActive(false);
            
        }
        

        
    }
    public void BuyCar2()
    {
        // HONDA
        if (PocketMoney > 7500)
        {
            PocketMoney -= 7500;
            secondCarbought = true;
            car2bought = 1;
            PlayerPrefs.SetInt("BuySecondCar", (secondCarbought ? 1 : 0));
            secondCarbought = (PlayerPrefs.GetInt("BuySecondCar") != 0);
            PlayerPrefs.SetFloat("PocketMoney", PocketMoney);
        }
        if (secondCarbought == true)
        {
            
            secondCar.SetActive(false);
            
        }



    }
    public void BuyCar3()
    {
        // BM
        if(PocketMoney > 20000)
        {
        PocketMoney -= 20000;
        thirdCarbought = true;
        car3bought = 1;
        PlayerPrefs.SetFloat("PocketMoney", PocketMoney);
        PlayerPrefs.SetInt("BuyThirdCar", (thirdCarbought ? 1 : 0));
        thirdCarbought = (PlayerPrefs.GetInt("BuyThirdCar") != 0);

        }
        if (thirdCarbought == true)
        {
            thirdCar.SetActive(false);
        }



    }
    public void BuyCar4()
    {
        // MERC
        if(PocketMoney > 50000)
        {
        PocketMoney -= 50000;
        fourthCarbought = true;
        car4bought = 1;
        PlayerPrefs.SetFloat("PocketMoney", PocketMoney);
        PlayerPrefs.SetInt("BuyFourthCar", (fourthCarbought ? 1 : 0));
        fourthCarbought = (PlayerPrefs.GetInt("BuyFourthCar") != 0);
        }
        if (fourthCarbought == true)
        {
            fourthCar.SetActive(false);
        }

       /////////////////////////////////////////////////////////////////////

    }
    public void BuyCar5()
    {
        // NSX
        if (PocketMoney > 150000)
        {
            PocketMoney -= 150000;
            PlayerPrefs.SetFloat("PocketMoney", PocketMoney);
            fifthCarbought = true;
            car5bought = 1;
            PlayerPrefs.SetInt("BuyFifthCar", (fifthCarbought ? 1 : 0));
            fifthCarbought = (PlayerPrefs.GetInt("BuyFifthCar") != 0);
        }
        if (fifthCarbought == true)
        {
            fifthCar.SetActive(false);
        }



    }

    public void BuyTimeSlow()
    {
        if (PocketMoney > 500)
        {
            PocketMoney -= 500;
            PlayerPrefs.SetFloat("PocketMoney", PocketMoney);
            TimeManager.TimeCount++;
            PlayerPrefs.SetInt("TimeCounter",TimeManager.TimeCount);
        }
        



    }
    

    
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Cosmetics()
    {
        CarHolder.SetActive(false);
        CosmeticHolder.SetActive(true);
        CosmeticButton1.SetActive(true);
        CosmeticButton2.SetActive(true);
    }
}
