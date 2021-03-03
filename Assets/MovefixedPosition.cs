using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovefixedPosition : MonoBehaviour
{
    [SerializeField]
    Vector3 moveVector = new Vector3(0.0625f, 0, 0);//秒速
    Rigidbody rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //GetComponent<Rigidbody>().MovePosition(this.transform.position + moveVector);
        rigidbody.MovePosition(this.transform.position + moveVector);
    }
}
