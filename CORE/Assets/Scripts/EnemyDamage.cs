using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject gameover;

 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HealthBar.health -= 7f;

            if (HealthBar.health <= 0) 
            {
                gameover.SetActive(true);
 

            }
        }
    }
}
