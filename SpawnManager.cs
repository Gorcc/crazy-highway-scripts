using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    Sidecontentspawner plotSpawner;
   
    
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<Sidecontentspawner>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
        
    }
}
