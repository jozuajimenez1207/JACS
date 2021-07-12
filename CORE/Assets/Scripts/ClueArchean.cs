using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ClueArchean : MonoBehaviour
{
    public GameObject containerUI;
    public TextMeshProUGUI chip_clue1;
    public TextMeshProUGUI chip_clue2;
    public TextMeshProUGUI chip_clue3;

    private void Start()
    {
        containerUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Aurora")
        {

            containerUI.SetActive(true);
            chip_clue1.text = "Only a part of a chip is here. " +
                "I don't think it will help me travel to the next eon. I have to find the other parts;";

            new WaitForSeconds(10);
            chip_clue1.gameObject.SetActive(false);
            containerUI.SetActive(false);
            
            containerUI.SetActive(true);
            chip_clue2.text = "I found another part. I just need to find the last one";
            
            /*new WaitForSeconds(10);
            chip_clue2.gameObject.SetActive(false);
            containerUI.SetActive(false);

            containerUI.SetActive(true);
            chip_clue3.text = " I found the last one, I need to go back to the ship right now";
            
            new WaitForSeconds(10);
            chip_clue3.gameObject.SetActive(false);
            containerUI.SetActive(false);*/
        
        }
    }


}
