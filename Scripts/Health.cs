using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] VictoryPlus victoryplus;
    [SerializeField] int health = 2;
    [SerializeField] float destroyDelay = 0.5f;
    

    void Start()
    {

    } 

    void Update()
    {
        if(health < 1)
        {
            if(victoryplus != null)
            {
                victoryplus.VictoryCall();
            }
            
            Destroy(gameObject, destroyDelay);
            
        }
    
    }

    void OnCollisionEnter(Collision other)
    {
        health -= 1;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "EarthLikeDesign1")
        {
            Destroy(gameObject, destroyDelay);
        }
        
        health -= 1;
    }

    

}
