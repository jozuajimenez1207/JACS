using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    [Tooltip("\"Fractured\" is the object that this will break into")]
    public GameObject fractured;
    private bool isFractured = false;

    public float timeForDestroy = 3;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
        isFractured = true;
    }

    void Update()
    {
        if (isFractured == false)
        {
            timeForDestroy -= Time.deltaTime;

            if (timeForDestroy < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void FractureObject()
    {
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
    }
}
