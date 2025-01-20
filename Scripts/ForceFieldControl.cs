using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldControl : MonoBehaviour
{

    [SerializeField] ParticleSystem forceField;
    public bool isshielded;
    public bool isBlocked = false;
    public float defaultBlockTime = 7;
    [SerializeField] float blockTime = 7;
    [SerializeField] ShieldTimer shieldTime;
    
    void Start()
    {
        forceField.Stop();
        shieldTime.slider.maxValue = defaultBlockTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        Forcefield();
        
    }

    public void Forcefield()
    {

        if (isBlocked == true)
        {
            blockTime -= Time.deltaTime;
            shieldTime.slider.value -= Time.deltaTime;
            if (blockTime <= 0f)
            {
                isBlocked = false;
                blockTime = defaultBlockTime;
            }
        }

        ActivateSchield();

        if (Input.GetKeyUp(KeyCode.Space) && forceField.isPlaying == true)
        {
            forceField.Stop();
            isshielded = false;
        }

        if (forceField.isPlaying == true)
        {
            isshielded = true;
        }
        if (forceField.isPlaying == false)
        {
            isshielded = false;
        }
    }

    public void ActivateSchield()
    {
        if (Input.GetKeyDown(KeyCode.Space) && forceField.isPlaying == false && isBlocked == false)
        {
            forceField.Play();
            isBlocked = true;
            shieldTime.Slidertimer();
        }
    }
}
