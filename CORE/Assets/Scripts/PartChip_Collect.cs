using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PartChip_Collect : MonoBehaviour
{
    public GameObject crate;
   
    public static int ChipPart = 0;
    void Start()
    {
        crate.SetActive(false);
        
    }

    private void Update()
    {
        if (Collectable.capsule == 10)
        {
            crate.SetActive(true);
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Aurora")
        {

            ChipPart++;
            gameObject.SetActive(false);
        }
    }
    /*IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        crate.SetActive(false);
    }*/
}
