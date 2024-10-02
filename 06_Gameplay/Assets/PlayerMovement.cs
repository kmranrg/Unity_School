using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // this is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // we marked this as FixedUpdate because we are using it to mess with Physics
    void FixedUpdate()
    {
        // adding a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a force of 2000 on the z-axis

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
