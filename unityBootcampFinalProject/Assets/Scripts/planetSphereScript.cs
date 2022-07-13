using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetSphereScript : MonoBehaviour
{
    public AudioSource sphereAudio;
    public ParticleSystem Effect;
    public GameObject Balloon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        sphereAudio.Play();
        gameObject.SetActive(false);
        
        Instantiate(Effect, Balloon.transform.position, Balloon.transform.rotation);
        Destroy(Balloon);
        //Destroy(Effect, 3);
        Effect.Stop();
        
        CalculatePoint.point += 5;
    }
}
