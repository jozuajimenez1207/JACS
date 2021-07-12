using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public static int capsule = 0;
    public TextMeshProUGUI Quest1;
    public TextMeshProUGUI objUI;
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
