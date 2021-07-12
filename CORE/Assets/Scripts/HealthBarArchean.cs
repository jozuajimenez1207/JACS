using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarArchean : MonoBehaviour
{
    public Image HealthBar;
    //public bool enter;
    public GameObject GameOver;
    public static float healthAmount;
    float FullHealth = 100f ;
    public float waittime = 30.0f;

    float EmptyHealth = 0f;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        healthAmount = FullHealth;
    }

    private void Update()
    {
        /*if (HealthBar.GetComponent<RectTransform>().anchoredPosition.x <= EmptyHealth) 
        {
            GameOver.SetActive(true);
        }*/

        HealthBar.fillAmount -= 0.5f / waittime * Time.deltaTime;
       
    }
}
