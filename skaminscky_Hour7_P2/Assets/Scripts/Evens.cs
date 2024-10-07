using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 22;
        while (count >= 22)
        {
            count += 2;
            Debug.Log( "count is" + count );
        }
        if (count >= 100)
        {
            Debug.Log( "Reached 100");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

