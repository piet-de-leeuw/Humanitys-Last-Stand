using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockedRanche : MonoBehaviour
{
    [SerializeField] ParticleSystem explode;
    [SerializeField] float ranche = 25f;
    void Update()
    {
        if(Vector3.Distance(transform.position, new Vector3(0,0,0)) > ranche)
        {
            explode.Play();
            Destroy(gameObject);
        }
    }
}
