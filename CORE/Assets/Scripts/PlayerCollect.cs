using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollect : MonoBehaviour
{
    // Start is called before the first frame update
   // public int capsule = 0;
    public GameObject wallDestroy; //unlock the area that cant be accessed unless quest 1 is finished
    public GameObject objUI;
    private IEnumerator coroutine;
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
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
            
        }
        
    }
    IEnumerator Remove()
    {      
        if (Collectable.capsule == 10)
        {
            yield return new WaitForSeconds(5);
            objUI.SetActive(false);
        }

    }

    
}
