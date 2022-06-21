using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Deleteprops : MonoBehaviour

{ 
    public GameObject explodeEffect;
    public CarController movement;
    [SerializeField] public static int rage = 0;
    public Text RageCount;
    public Text BankAccount;
    public Button restart;
    private Money score;
    public static float totalMoney = 0f;
    public GameObject destroyeffect;
    public GameObject car;
    public Store store;
    public GameManager Gamemanager;
    public static float extraMoney;
    public GameObject collideffect;
    public GameObject collideffect2;
    public Transform look;
    public Transform look2;
    public GameObject AngryText;
    public static bool TextUsed = false;
    public static bool caralive = true;
    public static int tipamount = 10;

    // Update is called once per frame


    
    IEnumerator AngryCustomer()
     {
            AngryText.SetActive(true);

            yield return new WaitForSeconds(2);

            AngryText.SetActive(false);
     }
    
    void Update()
    {
        
        
        if(rage >= 20 && rage <= 70)
        {
            if (TextUsed == false)
            {
                StartCoroutine(AngryCustomer());
                TextUsed = true;
            }
            
        }

        

        if (rage >= 100)
        {
            rage = 100;
            movement.enabled = false;
            caralive = false;

        }

        if(caralive == true)
        {
            movement.enabled = true;
        }
        if(caralive == false)
        {
            movement.enabled = false;
        }
        
        


    }
    // Destroy Collision


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "cookie")
        {
            if (rage > 0)
            {
                Instantiate(collideffect2, car.transform.position, car.transform.rotation);
                Destroy(collision.gameObject);
                rage -= 20;
                if(rage < 0)
                {
                    rage = 0;
                }
            }
            else
                Destroy(collision.gameObject);

        }

        if (collision.collider.tag == "money")
        {
            Instantiate(collideffect, car.transform.position, car.transform.rotation);
            Destroy(collision.gameObject);
            extraMoney += tipamount;
            

            if(Money.score > 30f)
            {
                extraMoney+= 20f;
            }

        }
        if (collision.collider.tag == "Wall")
        {
            
            rage += 30;

        }
            if (collision.collider.tag == "Bigprop")
        {
            Destroy(collision.gameObject, 1);
            
            rage += 30;


        }
        if (collision.collider.tag == "midprop")
        {
            Destroy(collision.gameObject, 1);
            rage += 15;

        }
        if (collision.collider.tag == "Props")
        {
            Destroy(collision.gameObject, 1);
            rage += 5;

        }
        if (collision.collider.tag == "movingcar")
        {
            Destroy(collision.gameObject, 1);
            rage += 100;

        }

        



    }
    

}


