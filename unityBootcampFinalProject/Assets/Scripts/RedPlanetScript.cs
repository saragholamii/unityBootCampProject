using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlanetScript : MonoBehaviour
{
     private int hitNumber = 0;
     public GameObject halghe1;
     public GameObject halghe2;
     public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("in the collision of red, number of hit:");
        Debug.Log(hitNumber);

        if(hitNumber == 0){
            halghe1.SetActive(false);
            halghe2.SetActive(false);
            hitNumber++;
        }

        else if(hitNumber == 1){
            sphere.SetActive(false);
        }

    }
}
