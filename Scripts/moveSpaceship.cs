using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpaceship : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float range = 7f;
    [SerializeField] float angle = 10;
    [SerializeField] GameObject missel;
    [SerializeField] float rangeShoot = 20f;
    float shootdelay;
    [SerializeField] float shootdelaydefault = 3f;

    GameObject Earth;
    
    void Start()
    {
        Earth = GameObject.Find("EarthLikeDesign1");
        shootdelay = shootdelaydefault;
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, Earth.transform.position) > range)
        {
            transform.LookAt(Earth.transform);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
        shootdelay -= Time.deltaTime;
        if(Vector3.Distance(transform.position, Earth.transform.position) < rangeShoot)
        {
            Shoot();
        }
        
        transform.RotateAround(Earth.transform.position, Vector3.up, angle * Time.deltaTime);
    }

    void Shoot()
    {
            
            if (shootdelay <= 0f)
            {
                Instantiate(missel, transform.position, transform.rotation);
                shootdelay = shootdelaydefault;
            }
            
    }
}
