using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // this is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // we marked this as FixedUpdate because we are using it to mess with Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // add a force of 2000 on the z-axis
    }
}
