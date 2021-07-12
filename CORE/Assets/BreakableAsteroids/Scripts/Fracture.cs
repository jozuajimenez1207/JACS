using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    [Tooltip("\"Fractured\" is the object that this will break into")]
    public GameObject fractured;
    public GameObject impactVFX;
    public GameObject trails;

    private bool isFractured;

    public float time = 3;

    void OnCollisionEnter(Collision collision)
    {
        var ImpactEffects = Instantiate(impactVFX, transform.position, transform.rotation) as GameObject; //Spawn the Impact Effects
        Destroy(ImpactEffects, 5);
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
        isFractured = true;

        var ps = trails.GetComponent<ParticleSystem>();
        ps.Stop(); Destroy(ps.gameObject, ps.main.duration + ps.main.startLifetime.constantMax);
    }

    void Update()
    {
        if (isFractured == true)
        {
            time -= Time.deltaTime;

            if (time < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void FractureObject()
    {
        var ImpactEffects = Instantiate(impactVFX, transform.position, transform.rotation) as GameObject; //Spawn the Impact Effects
        Destroy(ImpactEffects, 5);
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
        isFractured = true;

        var ps = trails.GetComponent<ParticleSystem>();
        ps.Stop(); Destroy(ps.gameObject, ps.main.duration + ps.main.startLifetime.constantMax);
    }
}