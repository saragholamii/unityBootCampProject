using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetCircleScript : MonoBehaviour
{
    public AudioSource circleAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        circleAudio.Play();
        gameObject.SetActive(false);
    }
}
