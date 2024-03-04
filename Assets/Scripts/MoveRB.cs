using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class MoveRB : MonoBehaviour
{
    [SerializeField] private float force = 50f;
    [SerializeField] private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force);
        }
        if (UnityEngine.Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector3.forward * force);
        }
        if (UnityEngine.Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force);
        }
        if (UnityEngine.Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force);
        }

    }
}
