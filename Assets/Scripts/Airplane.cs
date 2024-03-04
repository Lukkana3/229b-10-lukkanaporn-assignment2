using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float enginePowerThrust, liftBooster, drag, angularDrag/*แรงเลี้ยว*/;

    void FixedUpdate()
    {
        //Add Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * enginePowerThrust);
        }

        //Add Lift
        Vector3 lift = Vector3.Project(rb.velocity, Vector3.forward);
        rb.AddForce(Vector3.up * lift.magnitude * liftBooster);

        //Add Drag แรงต้าน
        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;
    }
}
