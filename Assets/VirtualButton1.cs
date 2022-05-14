using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton1 : MonoBehaviour
{
    public GameObject cubeGO, sphereGO;
    VirtualButtonBehaviour vrb;
    // Start is called before the first frame update
    void Start()
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterOnButtonPressed(onButtonPressed);
        vrb.RegisterOnButtonReleased(onButtonReleased);


    }

    // Update is called once per frame
    public void onButtonPressed(VirtualButtonBehaviour vrb)
    {
        cubeGO.SetActive(true);
        sphereGO.SetActive(false);
        Debug.Log("Button Pressed");


    }
    public void onButtonReleased(VirtualButtonBehaviour vrb)
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);
        Debug.Log("Button Released");

    }
}

