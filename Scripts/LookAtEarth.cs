using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtEarth : MonoBehaviour
{
    GameObject Earth;
    
    void Start()
    {
        Earth = GameObject.Find("EarthLikeDesign1");
    }

    void Update()
    {
        transform.LookAt(Earth.transform);
    }
}
