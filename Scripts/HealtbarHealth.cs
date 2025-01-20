using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealtbarHealth : MonoBehaviour
{

    [SerializeField] int maxHealth = 15;
    public int currentHealth;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] ParticleSystem destroy;
    public bool isExploding = false;
    

    [SerializeField] healthbar healthbar;

    [SerializeField] ForceFieldControl ForceField; 
    float delay = 2;
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.MaxHealth(maxHealth);
        isExploding = false;
    } 

    void Update()
    {
       
        if(currentHealth < 1)
        {
            
            delay -= Time.deltaTime;
            isExploding = true;
            if(delay <= 0f)
            {
               SceneManager.LoadScene(2);
            }
            
        }
    
    }

    void OnCollisionEnter(Collision other)
    {
        if(ForceField.isshielded == false)
        {
            currentHealth -= 1;
            healthbar.SetHealth(currentHealth);  
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "EarthLikeDesign1")
        {
            Destroy(gameObject, destroyDelay);
        }
        
        if(ForceField.isshielded == false)
        {
            currentHealth -= 1;
            healthbar.SetHealth(currentHealth);  
        }
        
        
    }

}
