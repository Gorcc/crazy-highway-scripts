
using UnityEngine;

public class CarModel : MonoBehaviour
{

    [SerializeField] private GameObject[] carModels;


    private void Awake()
    {
        
    }

    private void ChooseCarModel(int _index)
    {
        Instantiate(carModels[_index], transform.position, Quaternion.identity, transform);
    }
    
}
