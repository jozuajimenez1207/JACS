using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFracturedRock : MonoBehaviour
{

<<<<<<< Updated upstream
    public float time = 1;
=======
    public float time = 3;
>>>>>>> Stashed changes
    private bool isFractured;

    void Start()
    {
        isFractured = true;
    }

    void Update()
    {
        if (isFractured == true)
        {
            time -= Time.deltaTime;

            if (time < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Destroy(this.gameObject);
        }
    }
}
