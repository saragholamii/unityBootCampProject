using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    public AudioSource starAudio;
    public ParticleSystem Effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //*****
    private void OnCollisionEnter(Collision other) {
        gameObject.SetActive(false);
        starAudio.Play();
        Instantiate(Effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //Destroy(Effect, 1);
        Effect.Stop();
        CalculatePoint.point ++;
    }
}
