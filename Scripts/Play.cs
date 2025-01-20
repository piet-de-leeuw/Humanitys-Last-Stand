using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    ParticleSystem tail;
    void Start()
    {
        tail = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        tail.Play();    
        Debug.Log(tail.isPlaying);  
    }
}
