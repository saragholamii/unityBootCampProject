using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemet : MonoBehaviour
{

    //***** variables:
    public Rigidbody rb;
    Vector3 lastVelocity;
    public GameObject star;

    private void Start() {
        rb.AddForce(0, -10000 * Time.deltaTime, 0);
    }


    // Update is called once per frame
    void Update()
    {
    }

}
