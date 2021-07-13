using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollect : MonoBehaviour
{
    // Start is called before the first frame update
   // public int capsule = 0;
    public GameObject wallDestroy; //unlock the area that cant be accessed unless quest 1 is finished
    public GameObject objUI; //for capsules
    public GameObject drycellUI;
    public GameObject battery;
  
    private IEnumerator coroutine;
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
        drycellUI = GameObject.Find("DrycellNum");
        battery = GameObject.Find("DryCell");
        StartCoroutine("Remove");
    }
    
    // Update is called once per frame
    void Update()
    {
        
        objUI.GetComponent<Text>().text = Collectable.capsule.ToString();
        if (Collectable.capsule == 10)
        {
            Destroy(wallDestroy);
            objUI.GetComponent<Text>().text = "All capsules collected";
            battery.SetActive(true);
            
        }

        drycellUI.GetComponent<Text>().text = DryCell_Collect.drycells.ToString();
        if (DryCell_Collect.drycells == 2)
        {
            drycellUI.GetComponent<Text>().text = "Go back to the ship";

        }

    }
    IEnumerator Remove()
    {      
        if (Collectable.capsule == 10)
        {
            yield return new WaitForSeconds(5);
            objUI.SetActive(false);
        }

        if (DryCell_Collect.drycells == 2)
        {
            yield return new WaitForSeconds(5);
            drycellUI.SetActive(false);
        }

    }

    
}
