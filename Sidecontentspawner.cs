using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sidecontentspawner : MonoBehaviour
{
    private int initAmount = 30;
   
    private float plotSize = 30f;
    private float xPosLeft = -43f;
    private float xPosRight = 44.5f;
    private float lastZPos= -3.489f;
    public GameObject car;
    public int j=0;
    

    public List<GameObject> spawnedplots;

    

    public List<GameObject> plots;
   
    void Start()
    {
        
        



        for(int i=0; i < initAmount; i++)
        {

            SpawnPlot();
        }
        
    }

    
    void FixedUpdate()
    {
        
    }
    public void SpawnPlot()
    {
        int rand = Random.Range(0, plots.Count);
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];
        



        float zPos = lastZPos + plotSize;
        
        GameObject _plotLeft =Instantiate(plotLeft, new Vector3(xPosLeft, 0f, zPos), plotLeft.transform.rotation);
        GameObject _plotRight =Instantiate(plotRight, new Vector3(xPosRight, 0f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += plotSize;

        spawnedplots.Add(_plotLeft);
        spawnedplots.Add(_plotRight);




for (int a = 0; a < spawnedplots.Count; a++)
        {
            if (car.transform.position.z > spawnedplots[a].transform.position.z)
            {

                Destroy(spawnedplots[a]);

                spawnedplots.RemoveAt(a);


            }
        }
        








    }
    

}
