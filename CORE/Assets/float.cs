using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class float : MonoBehaviour
{

    public interface force;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform,.position.y > terrain.transform.position.y) {
            rigidbody.AddForce(transform.up * force * 10);

       }

         if (transform,.position.y < terrain.transform.position.y) {
            rigidbody.AddForce(-transform.up * force * 10);
        }
}
