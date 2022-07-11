using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovment : MonoBehaviour
{
    private float rotation;
    public float speedX = 20;
    public float speedy = 7;
    public float rotationPoint;
    //float timeCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d")) {
            if (rotation == 360) {
                rotation = 0;
            }   
            
            rotation += (rotationPoint * Time.deltaTime);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
            if (speedX < 0) {
                speedX *= -1;
            }
            gameObject.transform.Translate(speedX * Time.deltaTime, speedy * Time.deltaTime, 0);
        }
        if (Input.GetKey("a")) {
            
            rotation -= (rotationPoint * Time.deltaTime);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
            if (speedX > 0) {
                speedX *= -1;
            }
            gameObject.transform.Translate(speedX * Time.deltaTime, speedy * Time.deltaTime, 0);
        }
        
        /*
        float n = Input.GetAxis("Horizontal") * Time.deltaTime;
        timeCounter += n; // multiply all this with some speed variable (* speed);
        float x = Mathf.Cos (timeCounter) * speedX;
        float y = Mathf.Sin (timeCounter) * speedX;
        float z = 0;
        transform.position = new Vector3 (x, y, z);
        if (n < 0) {
    
            rotation -= (Time.deltaTime) * rotationPoint;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
        if (n > 0) {
        
            rotation += (Time.deltaTime) * rotationPoint;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
        */
    
    }
}
