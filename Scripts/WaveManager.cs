using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] TimeUntilLastStand timeUntilLastStand;
    [SerializeField] HealtbarHealth healtbarHealth;

    [SerializeField] Camera cam;

    [SerializeField] GameObject spawner;

    [SerializeField] GameObject wave1;
    [SerializeField] float delaywave1 = 3f;
    [SerializeField] GameObject wave2;
    [SerializeField] float delaywave2 = 7f;
    [SerializeField] GameObject wave3;
    [SerializeField] float delaywave3 = 7f;
    bool extraHealth = false;
    
    void Start()
    {
        spawner.SetActive(true);

        wave1.SetActive(false);
        wave2.SetActive(false);
        wave3.SetActive(false);
    }

    void Update()
    {
        


        if(timeUntilLastStand.hasEnded)
        {
            if(!extraHealth)
            {
                healtbarHealth.currentHealth += 7;
                extraHealth = true;
            }
            
            spawner.SetActive(false);
            
            delaywave1 -= Time.deltaTime;
            if(delaywave1 <= 0f)
            {
                wave1.SetActive(true);

                delaywave2 -= Time.deltaTime;
                if(delaywave2 <= 0f)
                {
                    wave2.SetActive(true);
                    delaywave3 -= Time.deltaTime;
                    if(cam.transform.position.y < 35)
                    {
                        cam.transform.position += new Vector3(0, Time.deltaTime, 0);
                    }
                    if(delaywave3 <= 0f)
                    {
                        wave3.SetActive(true);
                    }
                }
            }
            
            
        }
    }
}
