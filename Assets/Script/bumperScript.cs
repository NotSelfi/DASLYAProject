using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumperScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float bumpForce;

    private void OnTriggerEnter(Collider other)
    {
        var rb = other.GetComponent<Rigidbody>();
        if (null == rb)
        {
            return;
        }

        rb.AddForce(Vector3.up * bumpForce, ForceMode.VelocityChange);
    }
}
