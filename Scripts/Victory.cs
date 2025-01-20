using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    [SerializeField] ParticleSystem[] fireworks;

    [SerializeField] int victorycounter;

    float delay = 3f;
    bool go = false;
    int x = 0;


    // Start is called before the first frame update
    void Awake()
    {
        victorycounter = 0;
    }

    // Update is called once per frame
    void Update()
    {



        if(victorycounter >= 3)
        {
            go = true;

            if(go)
            {
                Delay();
                if (delay <= 0f)
                {
                    SceneManager.LoadScene(3);
                }
            }

            foreach(ParticleSystem firework in fireworks)
            {
                if(x >= fireworks.Length) {return;}
                fireworks[x].Play();
                x++;
            }
            
        }
    
    }

    public void VictoryCounter()
    {
        victorycounter += 1;
    }

    void Delay()
    {
        if(delay >= 0f)
        {
            delay -= Time.deltaTime;  
        }
        
    }

}