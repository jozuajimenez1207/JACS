using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameover;
    public GameObject task;



    private void Start()
    {
        pauseMenu.SetActive(false);
        gameover.SetActive(false);
        task.SetActive(false);
 

    }

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }


    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Task()
    {
        task.SetActive(!task.activeSelf);
   
    }
}