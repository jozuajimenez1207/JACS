using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFracturedRock : MonoBehaviour
{

    public float time = 5;
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
                Destroy(this.gameObject, 5);
            }
        }
    }
}
