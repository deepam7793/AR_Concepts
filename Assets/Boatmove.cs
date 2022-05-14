using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boatmove : MonoBehaviour
{
    void Update()
    {
        
        transform.Translate(new Vector3(0, 0, 0.5f) * Time.deltaTime);
    }
}
