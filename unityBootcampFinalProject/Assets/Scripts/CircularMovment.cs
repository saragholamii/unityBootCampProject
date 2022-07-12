using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovment : MonoBehaviour
{
    private float timeCounter;
    public float spead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        timeCounter += horizontal * Time.deltaTime;
        float x = Mathf.Cos(timeCounter - (Mathf.PI/2)) * spead;
        float y = Mathf.Sin(timeCounter - (Mathf.PI/2)) * spead;
        float z = 0;
        gameObject.transform.position = new Vector3(x, y, z);        
        gameObject.transform.up = gameObject.transform.position.normalized;
    
    }
}
