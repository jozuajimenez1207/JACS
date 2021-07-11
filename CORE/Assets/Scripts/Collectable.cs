using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static int capsule = 0;
    
    
    private void Awake()
    {
        //capsule--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Aurora")
        {
            capsule++;
            gameObject.SetActive(false);
        }
    }


}
