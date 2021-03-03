using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGen : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    Vector3 startPosition = Vector3.zero;
    [SerializeField]
    float amount = 10;
    [SerializeField] 
    float span = 1;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amount; i++)
        {
            Instantiate(prefab, startPosition + Vector3.forward * i*span, Quaternion.identity);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
