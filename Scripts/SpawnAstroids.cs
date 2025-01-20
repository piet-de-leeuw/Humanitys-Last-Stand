using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
// using System.Numerics;
using UnityEngine;

public class SpawnAstroids : MonoBehaviour
{
    public GameObject[] enemies;
    [SerializeField] Vector3 spawnValeus;
    [SerializeField] float spawnWait;
    [SerializeField] float spawnMostWait;
    [SerializeField] float spawnLeastwait;
    [SerializeField] int startWait;
    [SerializeField] bool stop;

    int randEnemy;
    void Start()
    {
        StartCoroutine(WaitSpawner());
    }

   
    void Update()
    {
        spawnWait = Random.Range(spawnLeastwait, spawnMostWait);
    }

    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, enemies.Length);
            Debug.Log(enemies.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValeus.x, spawnValeus.x), 0,Random.Range(-spawnValeus.z, spawnValeus.z));

            Instantiate( enemies[randEnemy], spawnPosition + transform.TransformPoint(0,0,0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
    
}
