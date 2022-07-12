using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemet : MonoBehaviour
{

    //***** variables:
    public Rigidbody rb;
    Vector3 lastVelocity;
    public AudioSource loseAudio;

    private void Start() {
        Debug.Log("inside start");
        rb.AddForce(0, -30000 * Time.deltaTime, 0);
    }


    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.CompareTag("Cube")){
            loseAudio.Play();
            gameObject.SetActive(false);
        }

        lastVelocity = rb.velocity;

        var direction = -Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal); 
        
        rb.velocity = direction * 7;
    }

}
