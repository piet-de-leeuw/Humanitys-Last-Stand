using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEarthCursor : MonoBehaviour
{

    GameObject target;
    
    void Start()
    {
        target = GameObject.Find("EarthLikeDesign1");
    }

    void Update()
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }
}