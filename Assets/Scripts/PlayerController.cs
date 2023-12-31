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
        //上移動
        if (Input.GetKey("w"))
        {
            Debug.Log("w");
            rigidbody.AddForce(transform.forward * Speed, ForceMode.Acceleration);
            transform.Rotate(Vector3.up,90);
        }

        //下移動
        if (Input.GetKey("s"))
        {
            Debug.Log("s");
            rigidbody.AddForce(transform.forward * -Speed, ForceMode.Acceleration);
        }

        //左移動
        if (Input.GetKey("a"))
        {
            Debug.Log("a");
            rigidbody.AddForce(transform.right * -Speed, ForceMode.Acceleration);
        }

        //右移動
        if (Input.GetKey("d"))
        {
            Debug.Log("d");
            rigidbody.AddForce(transform.right * Speed, ForceMode.Acceleration);
        }
    }
}
