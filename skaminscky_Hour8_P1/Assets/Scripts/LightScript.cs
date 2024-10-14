using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    //public LightScript pauseMenu;
    Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.intensity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
            Debug.Log("The 'L' key was pressed and the light is now off!");
            myLight.intensity = 0;
            //pauseMenu.enabled = true;
    }
}
