using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawn : MonoBehaviour
{
   
        public GameObject Car;
        public GameObject[] obstaclePerefab;
        public float spawnTime = 1;
        private float timer = 0;
        private Deleteprops rage;

  
    void Update()
    {
        if (timer > spawnTime)
        {
            int rand = Random.Range(0, obstaclePerefab.Length);
            GameObject obs = Instantiate(obstaclePerefab[rand]);
            obs.transform.position = transform.position + new Vector3(-70.3f, 42.5f, Car.transform.position.z + 60);
            Destroy(obs, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
        
    }

}
