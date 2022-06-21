using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCam : MonoBehaviour
{ 
    private Transform player;
    private float yOffset = 3.5f;
    private float zOffset = -12f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Car").transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + yOffset, player.position.z + zOffset);
        transform.LookAt(player);
    }
}
