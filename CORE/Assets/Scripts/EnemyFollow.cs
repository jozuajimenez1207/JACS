using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    public Transform Player;
    Animator anim;


    string state = "patrol";
    public GameObject[] waypoints;
    int currentWP = 0;
    float rotSpeed = 5f;
    float speed = 22.5f;
    float accuracyWP = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.position - this.transform.position;
        direction.y = 0;


        if (state == "patrol" && waypoints.Length > 0)
        {
            anim.SetBool("IsIdle", false);
            anim.SetBool("IsRunning", true);
            if (Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracyWP)
            {
                currentWP++;
                if (currentWP >= waypoints.Length)
                {
                    currentWP = 0;
                }
            }

            direction = waypoints[currentWP].transform.position - transform.position;
            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
            this.transform.Translate(0, 0, Time.deltaTime * speed);
        }
        if (Vector3.Distance(Player.position, this.transform.position) <48)
        {
            state = "pursuing";
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
            if (direction.magnitude > 15)
            {
                this.transform.Translate(0, 0, Time.deltaTime * speed);
                anim.SetBool("IsRunning", true);
                anim.SetBool("IsBiting", false);

            }
            else
            {
                anim.SetBool("IsBiting", true);
                anim.SetBool("IsRunning", false);

            }
        }
        else
        {


            anim.SetBool("IsRunning", true);
            anim.SetBool("IsBiting", false);
            state = "patrol";
        }






    }
}
