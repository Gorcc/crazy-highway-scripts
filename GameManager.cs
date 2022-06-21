using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
    private Deleteprops rage;
    public GameObject GameOver;
    private Money Money;
    private Store Store;
    private CarSelection Car;
    public static bool isDead;
    public GameObject ObsSpawner;
    public GameObject car;

    
    public static float GameOverMoney;
    public static int adCount;
    void Start()
    {
        Deleteprops.caralive = true;
    }



    void Update()
    {
        EndGame();
        GameOverMoney = Deleteprops.extraMoney + Money.bankaccount;

        if (Deleteprops.rage == 100)
        {
            

            Deleteprops.rage = 0;
        }
    }
    void EndGame ()
    {
        if(Deleteprops.rage >= 100)
        {
            GameOver.SetActive(true);
            isDead = true;
            adCount++;
            if (adCount == 3)
            {
                adCount = 0;
            }
            if (isDead== true)
            {

                if(adCount == 2)
                {
                    
                }
                MoneyAdd();
                isDead = false;
                
                ObsSpawner.SetActive(false);
            }
           
           
        }
    }
    public static void MoneyAdd()
    {
            CarSelection.PocketMoney = PlayerPrefs.GetFloat("PocketMoney");
            CarSelection.PocketMoney += Money.bankaccount;
            CarSelection.PocketMoney += Deleteprops.extraMoney;
            
        
            PlayerPrefs.SetFloat("PocketMoney", CarSelection.PocketMoney);
            
        
    }
    public void RestartButton()
    {
        Store.PocketMoney += Money.score;
        Deleteprops.rage = 0;
        Deleteprops.extraMoney = 0;
        SceneManager.LoadScene("Level1");
        Deleteprops.TextUsed = false;
        
        
        
        




    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
        Deleteprops.rage = 0;

    }

    public void ContinueButton()
    {
        
        GameOver.SetActive(false);
        Deleteprops.caralive = true;
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        
        yield return new WaitForSeconds(2);
        ObsSpawner.SetActive(true);
    }

}
