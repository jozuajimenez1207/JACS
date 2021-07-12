using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCollect : MonoBehaviour
{
    // Start is called before the first frame update
   // public int capsule = 0;
    public GameObject wallDestroy; //unlock the area that cant be accessed unless quest 1 is finished
    public TextMeshProUGUI objUI; //for capsules
    public TextMeshProUGUI drycellUI; // for dry cells
    public TextMeshProUGUI chipPartUI;
    public TextMeshProUGUI Quest1UI; // quests 
    public TextMeshProUGUI Quest2UI;
    public TextMeshProUGUI Quest3UI;
    public GameObject battery;
    public GameObject crate;
  
    private IEnumerator coroutine;
    void Start()
    {
        battery = GameObject.Find("DryCell");
        //crate = GameObject.Find("Crate");
        //StartCoroutine("Remove");
    }
    
    // Update is called once per frame
    void Update()
    {

        Quest1UI.text = "Quest 1: You need to collect all the oxygen capsules scattered in this area";
        objUI.text = "Capsules: " + Collectable.capsule.ToString();

        if (Collectable.capsule == 10)
        {   
            
            Destroy(wallDestroy);
            objUI.text = "All capsules collected";
            new WaitForSeconds(30);
            Quest1UI.gameObject.SetActive(false);
            objUI.gameObject.SetActive(false); 
            
            crate.SetActive(true);

            Quest2UI.text = "Quest 2: Parts of the Chip";
            chipPartUI.text = "Parts: " + PartChip_Collect.ChipPart.ToString();
           
        }

        if (PartChip_Collect.ChipPart == 3)
        {
            chipPartUI.text = "The Chip is now complete go back to the ship";
            new WaitForSeconds(30);
            Quest2UI.gameObject.SetActive(false);
            chipPartUI.gameObject.SetActive(false);
            battery.SetActive(true);
            
            Quest3UI.text = "Quest 3: Find the batteries to power-up your ship";
            drycellUI.text = "Drycells: " + DryCell_Collect.drycells.ToString();
           
        }

        if (DryCell_Collect.drycells == 2)
        {
            drycellUI.text = "Go back to the ship";
            new WaitForSeconds(30);
            Quest3UI.gameObject.SetActive(false);
            drycellUI.gameObject.SetActive(false);
        }

    }
    /*IEnumerator Remove()
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

    }*/

    
}
