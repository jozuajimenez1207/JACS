using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject Ship;

    public GameObject MeteorPrefab;

    public Vector3 center;
    public Vector3 size;

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("MeteorSpawn", spawnTime, spawnDelay);
    }

    void Update()
    {
        if (Ship == null)
        {
            CancelInvoke("MeteorSpawn");
        }
    }

    public void MeteorSpawn()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(MeteorPrefab, pos, Quaternion.identity);

        if(stopSpawning == true)
        {
            CancelInvoke("MeteorSpawn");
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
