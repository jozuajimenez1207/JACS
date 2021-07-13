using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuizCountdown : MonoBehaviour
{
    Image timeBar;
    
    float timeLeft;

    public QuizManager quizManager;

    public float maxTime = 0f;

    // Start is called before the first frame update
    public void Start()
    {
  
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }


    // Update is called once per frame
    public void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            quizManager.GameOver();

        }
    }
    
}
