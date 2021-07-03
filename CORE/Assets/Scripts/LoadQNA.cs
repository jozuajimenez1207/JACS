﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadQNA : MonoBehaviour
{
    public GameObject Trigger;


    // Start is called before the first frame update
    void Start()
    {
        Trigger.SetActive(true);

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("PHANEROZOIC EON-2(MESOZOIC)");

        }
    }
}
