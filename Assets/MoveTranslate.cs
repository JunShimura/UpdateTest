using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTranslate : MonoBehaviour
{
    [SerializeField]
    Vector3 moveVector = new Vector3(0.0625f, 0, 0);//秒速
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + new Vector3(0.0625f,0,0);
        transform.position = transform.position + moveVector*Time.deltaTime;
    }
}
