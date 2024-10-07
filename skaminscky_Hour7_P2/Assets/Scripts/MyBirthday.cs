using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 1;
        while (count <= 1)
        {
            count = 1;
            Debug.Log( count );
            if (count == 7)
            {
                Debug.Log( "Hey! Its my birthday!");
            }
        }
        if (count == 30)
        {
            Debug.Log( count );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
