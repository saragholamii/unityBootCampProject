using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatePoint : MonoBehaviour
{
    public TextMesh pointer;
    public static int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointer.text = "Point : "+ point;
    }
}
