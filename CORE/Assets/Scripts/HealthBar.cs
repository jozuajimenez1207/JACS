using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject impactVFX;
    public AudioSource explosionSound;
    public GameObject Ship;
    public GameObject gameOver;

    public Image healthbar;
    float maxHealth = 100f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healthbar  = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health / maxHealth;
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            HealthBar.health -= 10f;
        }
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        healthbar.fillAmount = health / maxHealth;

        if (health <= 0)
        {
            explosionSound.Play();

            gameOver.SetActive(true);

            var ImpactEffects = Instantiate(impactVFX, Ship.transform.position, Ship.transform.rotation) as GameObject;
            Destroy(ImpactEffects, 5);

            Destroy(Ship);
        }
    }
}
