using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(.05f, 0f, 0f);
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if(mxVal != 0)
            Debug.Log("Mouse X movement selected: " + mxVal);
        if(myVal != 0)
            Debug.Log("Mouse Y movement selected: " + myVal);
    }
}
