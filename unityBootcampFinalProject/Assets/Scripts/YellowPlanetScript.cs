using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlanetScript : MonoBehaviour
{
    //**** tedad zarbe heye khorde shode ra negah midarad.
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

        if(hitNumber == 0){
            halghe1.SetActive(false);
            halghe2.SetActive(false);
            hitNumber++;
        }

        else if(hitNumber == 1){
            sphere.SetActive(false);
        }
        CalculatePoint.point ++;

    }
}
