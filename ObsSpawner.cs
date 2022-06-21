using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{

    public GameObject Car;
    public GameObject[] obstaclePerefab;
    public float spawnTime = 1.5f;
    private float timer = 0;
    private Money score;
    private int initAmount = 10;
    private float zPos = 0;
    
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
           
            int rand = Random.Range(0, obstaclePerefab.Length);
            GameObject obs = Instantiate(obstaclePerefab[rand]);
            
            obs.transform.position = transform.position + new Vector3(0, 0,zPos + 100);
            zPos += 100;

        }
        score = GetComponent<Money>();
        

    }


    void FixedUpdate()
    {
        if (timer > spawnTime)
        {
            int rand = Random.Range(0, obstaclePerefab.Length);
            GameObject obs = Instantiate(obstaclePerefab[rand]);
            obs.transform.position = transform.position + new Vector3(0, 0, Car.transform.position.z + 100); 
            Destroy(obs, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
        if(Money.score < 9)
        {
            spawnTime = 1.5f;
        }
        if (Money.score > 9)
        {
            spawnTime = 1f;
        }
        if (Money.score > 24)
        {
            spawnTime = 0.7f;
        }
        if (Money.score > 59)
        {
            spawnTime = 0.55f;
        }

        if(Money.score > 64)
        {
            spawnTime = 0.4f;
        }

    }
}