using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetSphereScript : MonoBehaviour
{
    public AudioSource sphereAudio;
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
    }
}
