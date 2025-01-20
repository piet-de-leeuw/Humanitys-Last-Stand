using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class moveToEarth : MonoBehaviour
{

    [SerializeField] float speed = 0.1f;

    GameObject Earth;
    
    void Start()
    {
        Earth = GameObject.Find("EarthLikeDesign1");
    }

    void Update()
    {
        transform.LookAt(Earth.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
