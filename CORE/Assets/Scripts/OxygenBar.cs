using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    public Image oxygenbar;
    float fullOxygen = 100;
    float emptyOxygen = 0;
    public static float WaitTime = 25f; 

    private void Start()
    {
        oxygenbar = GetComponent<Image>();
    }

    private void Update()
    {
        oxygenbar.fillAmount -= 0.5f / WaitTime * Time.deltaTime;
    }
}
