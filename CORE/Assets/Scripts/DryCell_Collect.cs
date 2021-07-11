using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DryCell_Collect : MonoBehaviour
{
    public static int drycells = 0;
    public GameObject DryCell;
    // Start is called before the first frame update
    void Start()
    {
        DryCell.SetActive(false);
    }

    private void Update()
    {
        if (Collectable.capsule == 10)
        {
            DryCell.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Aurora")
        {
            drycells++;
            gameObject.SetActive(false);
        }
    }
}
