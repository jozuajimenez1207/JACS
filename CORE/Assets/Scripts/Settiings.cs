using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settiings : MonoBehaviour
{
    public GameObject settingsHolder;
    public GameObject audiosettingsHolder;


    public void QuitGame()
    {
        Application.Quit();
    }

    public void AudioSettingsMenu()
    {
        settingsHolder.SetActive(false);
        audiosettingsHolder.SetActive(true);
  
    }

    public void SettingsMenu()
    {
        settingsHolder.SetActive(true);
        audiosettingsHolder.SetActive(false);

    }

    public void SetMasterVolume(float value)
    {

    }

    public void SetMusicVolume(float value)
    {

    }

    public void SetSfxVolume(float value)
    {

    }
}
