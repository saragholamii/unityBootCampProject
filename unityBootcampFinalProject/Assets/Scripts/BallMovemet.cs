using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemet : MonoBehaviour
{

    //***** variables:
    public Rigidbody rb;
    Vector3 lastVelocity;
    public AudioSource loseAudio;
    public AudioSource ShootAudio;
    private int heart = 7;
    public GameObject[] Balloon;
    public ParticleSystem Effect;

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

            Instantiate(Effect, Balloon[heart-1].transform.position, Balloon[heart-1].transform.rotation);
            Destroy(Balloon[heart-1]);
            Effect.Stop();
            loseAudio.Play();
            if (heart == 1) {
                gameObject.SetActive(false);
            }
            else {
                heart --;
            }
            
        }
        if(other.gameObject.CompareTag("Disk")){
            ShootAudio.Play();
        }

        lastVelocity = rb.velocity;

        var direction = -Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal); 
        
        rb.velocity = direction * 7;
    }

}
