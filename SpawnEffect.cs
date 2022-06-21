
using UnityEngine;

public class SpawnEffect : MonoBehaviour
{


    public GameObject Spawneffect;
    public GameObject obstacle;


    void Start()
    {
        Instantiate(Spawneffect, obstacle.transform.position, obstacle.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
