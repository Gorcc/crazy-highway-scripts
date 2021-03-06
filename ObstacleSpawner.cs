using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{



    public GameObject[] obstaclePerefab;


    public float spawnTime = 1;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            int rand = Random.Range(0, obstaclePerefab.Length);
            GameObject obs = Instantiate(obstaclePerefab[rand]);
            obs.transform.position = transform.position + new Vector3(42, 28, 0);
            Destroy(obs, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
