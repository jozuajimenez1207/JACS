using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameover;


    private void Start()
    {
        pauseMenu.SetActive(false);
        gameover.SetActive(false);


    }

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }


    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}