using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShootToCursor : MonoBehaviour
{

    [SerializeField] GameObject missel;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Creates Ray to mousposition
        if(Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(ray, out RaycastHit hit);   // raycasts Ray ray and returns hitinformation
            transform.LookAt(hit.point);    // turns transform to mouseposition at the moment of the click.

            Instantiate(missel, transform.position, transform.rotation);
            
            
        }
    }
}
