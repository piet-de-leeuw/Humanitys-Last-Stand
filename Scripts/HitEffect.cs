using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitEffect : MonoBehaviour
{

    ParticleSystem effect;

    void Start()
    {
        effect = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        effect.Play();
    }
}
