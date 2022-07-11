using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemet : MonoBehaviour
{

    //***** variables:
    public Rigidbody rb;
    Vector3 lastVelocity;

    private void Start() {
        rb.AddForce(-10000 * Time.deltaTime, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
    }

    //***** in method tavasot khod unity seda zade mishavad.
    // void OnCollisionEnter(Collision other) {
    //     Debug.Log("inside colllision");
    //     lastVelocity = rb.velocity;

    //     Debug.Log("velocity avalie");
    //     Debug.Log(lastVelocity);

    //     //***** check mikonim shy ie ke ba an barkhord karde im boshghab hast ya na.
    //     if(other.gameObject.CompareTag("BigCircle") || other.gameObject.CompareTag("SmallCircle")){
    //         Debug.Log("inside if in collision");

    //         var speed = lastVelocity.magnitude;
    //         var direction = -Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);

    //         rb.velocity = direction * speed;

    //         Debug.Log("bad az avaz kardan velocity");
    //         Debug.Log(rb.velocity);
    //     }
    // }
}
