using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float enginePowerThrust, lift, drag, angularDrag/*�ç������*/;

    void FixedUpdate()
    {
        //Add Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * enginePowerThrust);
        }
    }
}
