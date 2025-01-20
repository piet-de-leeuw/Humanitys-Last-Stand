using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEarth : MonoBehaviour
{

    [SerializeField] HealtbarHealth Earth;
    [SerializeField] ParticleSystem destroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Earth.isExploding)
        {
            destroy.Play();
        }
    }
}
