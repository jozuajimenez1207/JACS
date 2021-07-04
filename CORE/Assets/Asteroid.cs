using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // trigger ship to explode when it collides with this
        other.transform.parent.gameObject.GetComponent<ShipControl>().Explode();
    }
}
