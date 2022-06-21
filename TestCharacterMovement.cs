using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterMovement : MonoBehaviour
{
    
    public float movementSpeed = 0f;

    public SpawnManager spawnManager;
    // Start is called before the first frame update
    





    void Update()
    {

        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2 ;
        float vMovement = 1 * movementSpeed;


        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

    }


    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();

    }
}
