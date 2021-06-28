using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject hide;


    private void Start()
    {
        pauseMenu.SetActive(false);
        hide.SetActive(false);
    }

    public void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }

    public void HideJoystick()
    {
        hide.SetActive(!hide.activeSelf);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}