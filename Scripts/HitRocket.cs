using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRocket : MonoBehaviour
{
    ParticleSystem effect;

    void Start()
    {
        effect = GetComponent<ParticleSystem>();      
    }

    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        effect.Play();
    }
}
