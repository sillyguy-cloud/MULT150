using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public int count = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        count++;
        print("Sphere bounced the cube" + count + "times!");
    }
}