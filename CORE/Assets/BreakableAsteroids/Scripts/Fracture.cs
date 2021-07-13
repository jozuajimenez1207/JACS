using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    [Tooltip("\"Fractured\" is the object that this will break into")]
    public GameObject fractured;
    public GameObject impactVFX;
    public List<GameObject> trails;

    private bool isFractured = false;

    public float time = 1.5f;

    void OnCollisionEnter(Collision collision)
    {
        var ImpactEffects = Instantiate(impactVFX, transform.position, transform.rotation) as GameObject; //Spawn the Impact Effects
        Destroy(ImpactEffects, 5);
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
        isFractured = true;

<<<<<<< Updated upstream
        if (trails.Count > 0)
        {
            for (int i = 0; i < trails.Count; i++)
            {
                trails[i].transform.parent = null;
                var ps = trails[i].GetComponent<ParticleSystem>();
                
                if (ps != null)
                {
                    ps.Stop();
                    Destroy(ps.gameObject, ps.main.duration + ps.main.startLifetime.constantMax);
                }
            }
=======
        var ps = trails.GetComponent<ParticleSystem>();
        ps.Stop();
        Destroy(ps.gameObject, ps.main.duration + ps.main.startLifetime.constantMax);

        if (collision.gameObject.tag == "ground")
        {
            Destroy(ImpactEffects);
            Destroy(gameObject);
            ps.Stop();
            Destroy(ps.gameObject);
>>>>>>> Stashed changes
        }
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
        else if (isFractured == false)
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
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
    }
}
