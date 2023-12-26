using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 10f;
    private Rigidbody rigidbody;
    private Transform transform;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
        Debug.Log("ok");

    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        //��ړ�
        if (Input.GetKey("w"))
        {
            Debug.Log("w");
            rigidbody.AddForce(transform.forward * Speed, ForceMode.Acceleration);
            transform.Rotate(Vector3.up,90);
        }

        //���ړ�
        if (Input.GetKey("s"))
        {
            Debug.Log("s");
            rigidbody.AddForce(transform.forward * -Speed, ForceMode.Acceleration);
        }

        //���ړ�
        if (Input.GetKey("a"))
        {
            Debug.Log("a");
            rigidbody.AddForce(transform.right * -Speed, ForceMode.Acceleration);
        }

        //�E�ړ�
        if (Input.GetKey("d"))
        {
            Debug.Log("d");
            rigidbody.AddForce(transform.right * Speed, ForceMode.Acceleration);
        }
    }
}
