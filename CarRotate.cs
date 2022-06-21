
using UnityEngine;

public class CarRotate : MonoBehaviour
{
    public GameObject Rotate;
    public float RotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Rotate.transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
    }
}
