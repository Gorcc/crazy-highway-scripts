using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class CarController : MonoBehaviour
{

    //
    
    public Rigidbody theRB;
    
    public float reverseAccel = 4f, maxSpeed = 50f, turnStrength = 180f, gravityForce =10f,dragOnGround=3f;
    public static float forwardAccel = 5f;
    private float speedInput, turnInput;
    private bool grounded;
    public LayerMask whatIsGround;
    public float groundRayLengght = .5f;
    public Transform groundRayPoint;
    public Transform leftfrontwheel, rightfrontwheel, leftfrontwheel1, rightfrontwheel1, leftfrontwheel2, rightfrontwheel2, leftfrontwheel3, rightfrontwheel3, rightfrontwheel4,leftfrontwheel4,rightfrontwheel5, leftfrontwheel5;
    public CosmeticSelector cosmetics;
    public bool skillisacitve = false;
    
    public float maxWheelTurn;
    private bool speedUp;
    private Money score;
    private float yValue;
    private float yPos;
    public GameObject car;
    public GameObject drifteffect;
    public GameObject effectpoint;
    public GameObject effectpoint2;
    public GameObject exhaust;
    public GameObject exhausteffect;
    public CarSelection startupcar;

    // Cars
    public GameObject car0;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car5;

    // Cosmetics
    public GameObject cosmetic1;
    public GameObject cosmetic2;
    public GameObject cosmetic3;
    public GameObject cosmetic4;


    void Start()
    {
        
        if(CarSelection.startupcar == 1 && CarSelection.firstCarbought == true)
        {
            car0.SetActive(false);
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);

        }
        if (CarSelection.startupcar == 2 && CarSelection.secondCarbought == true)
        {
            car0.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(true);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
        }
        if (CarSelection.startupcar == 3 && CarSelection.thirdCarbought == true)
        {
            car0.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(true);
            car4.SetActive(false);
            car5.SetActive(false);
        }
        if (CarSelection.startupcar == 4 && CarSelection.fourthCarbought == true)
        {
            car0.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(true);
            car5.SetActive(false);
        }
        
        if (CarSelection.startupcar == 6 && CarSelection.fifthCarbought == true)
        {

            car0.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(true);
        }
        if (CarSelection.startupcar == 0)
        {
            car0.SetActive(true);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
        }



        score = GetComponent<Money>();
        theRB.transform.parent = null;
        
    }

    void Update()
    {
        
        
        // Movement of the car
        
        
        speedInput = 0f;
        speedInput = 1 * forwardAccel * 1000f;
        turnInput = CrossPlatformInputManager.GetAxis("Horizontal");
        yValue = turnInput * turnStrength * Time.deltaTime * 1;
        yPos = Mathf.Clamp(yValue, -0.5f, 0.5f);

        
        if(forwardAccel >= 20)
        {
            if (CrossPlatformInputManager.GetAxis("Horizontal") == 1 || CrossPlatformInputManager.GetAxis("Horizontal") == -1)
            {

                Instantiate(drifteffect, effectpoint.transform.position, effectpoint.transform.rotation);
                Instantiate(drifteffect, effectpoint2.transform.position, effectpoint2.transform.rotation);

            }
        }
        
        // TURN WHEELS


        if (grounded)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, yValue, 0f));
        }
        transform.position = theRB.transform.position;
        // STARTER CAR
        leftfrontwheel.localRotation = Quaternion.Euler(leftfrontwheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), leftfrontwheel.localRotation.eulerAngles.z);
        rightfrontwheel.localRotation = Quaternion.Euler(rightfrontwheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), rightfrontwheel.localRotation.eulerAngles.z);


        // MAZDA

        leftfrontwheel4.localRotation = Quaternion.Euler(leftfrontwheel4.localRotation.eulerAngles.x, (-90+ turnInput * maxWheelTurn), rightfrontwheel4.localRotation.eulerAngles.z);
        rightfrontwheel4.localRotation = Quaternion.Euler(rightfrontwheel4.localRotation.eulerAngles.x, (-90+turnInput * maxWheelTurn), rightfrontwheel4.localRotation.eulerAngles.z);


        // MERCEDES

        leftfrontwheel1.localRotation = Quaternion.Euler(leftfrontwheel1.localRotation.eulerAngles.x, (-90 + turnInput * maxWheelTurn), rightfrontwheel1.localRotation.eulerAngles.z);
        rightfrontwheel1.localRotation = Quaternion.Euler(rightfrontwheel1.localRotation.eulerAngles.x, (90 + turnInput * maxWheelTurn), rightfrontwheel1.localRotation.eulerAngles.z);

        // BMW


        leftfrontwheel2.localRotation = Quaternion.Euler(leftfrontwheel2.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), rightfrontwheel2.localRotation.eulerAngles.z);
        rightfrontwheel2.localRotation = Quaternion.Euler(rightfrontwheel2.localRotation.eulerAngles.x, (180 + turnInput * maxWheelTurn), rightfrontwheel2.localRotation.eulerAngles.z);

        // HONDA

        leftfrontwheel3.localRotation = Quaternion.Euler(leftfrontwheel3.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), rightfrontwheel3.localRotation.eulerAngles.z);
        rightfrontwheel3.localRotation = Quaternion.Euler(rightfrontwheel3.localRotation.eulerAngles.x, ( turnInput * maxWheelTurn), rightfrontwheel3.localRotation.eulerAngles.z);

        // NSX

        leftfrontwheel5.localRotation = Quaternion.Euler(leftfrontwheel5.localRotation.eulerAngles.x, (+90 + turnInput * maxWheelTurn), rightfrontwheel5.localRotation.eulerAngles.z);
        rightfrontwheel5.localRotation = Quaternion.Euler(rightfrontwheel5.localRotation.eulerAngles.x, (-90 + turnInput * maxWheelTurn), rightfrontwheel5.localRotation.eulerAngles.z);

    }

    private void FixedUpdate()
    {

     
        grounded = false;
        
        RaycastHit hit;
        if(Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLengght, whatIsGround))
        {

            grounded = true;
            
            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }

        if (grounded)
        {
            theRB.drag = dragOnGround;
            if (Mathf.Abs(speedInput) > 0)
            {
                theRB.AddForce(transform.forward * speedInput);
            }
        }
        else
        {

            theRB.drag = 0.1f;
            theRB.AddForce(Vector3.up * -gravityForce * 100f);
        }
        
        // CAR SPEED UP

        if (Money.score < 10)
        {
            forwardAccel = 12;
        }

        if (Money.score > 10 && Money.score < 11)
        {
            forwardAccel = 15;
        }
        if(Money.score > 20 && Money.score < 21)
        {
            forwardAccel = 17;
        }
        if(Money.score > 35 && Money.score < 36)
        {
            forwardAccel = 20;
        }

        if(Money.score > 50 && Money.score > 51)
        {
            forwardAccel = 25;
            

        }

        // Cowboy Hat
        if(CosmeticSelector.currentCarIndex == 0 && CosmeticSelector.Buy1Check == 1)
        {
            cosmetic1.SetActive(true);
            
        }
        // Hard Hat
        if (PlayerPrefs.GetInt("SelectedCar") == 1 && CosmeticSelector.Buy2Check == 1)
        {
            cosmetic2.SetActive(true);

            if (skillisacitve == false)
            {
                Deleteprops.rage -= 50;
                skillisacitve = true;
             }
            
        }
        // Pirate Hat
        if (PlayerPrefs.GetInt("SelectedCar") == 2 && CosmeticSelector.Buy3Check == 1)
        {
            cosmetic3.SetActive(true);
            if (skillisacitve == false)
            {
                Deleteprops.tipamount = 15;
            }
        }
        // Wizard Hat
        if (PlayerPrefs.GetInt("SelectedCar") == 3 && CosmeticSelector.Buy4Check == 1)
        {
            cosmetic4.SetActive(true);

            if(skillisacitve == false)
            {
                TimeManager.TimeCount += 1;
                PlayerPrefs.SetInt("TimeCounter", TimeManager.TimeCount);
                skillisacitve = true;
            }
        }




    }





}
