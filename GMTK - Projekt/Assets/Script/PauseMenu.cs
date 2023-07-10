using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEditor.UI;

public class PauseMenu : MonoBehaviour
{
    
    [SerializeField] UnityEngine.UI.Slider soundSlider;
    [SerializeField] AudioMixer masterVolume;
    [SerializeField] UnityEngine.UI.Slider SFXSlider;
    [SerializeField] UnityEngine.UI.Slider MusicSlider;

    public static bool paused = false;

    public GameObject pauseMenuUi;



    public void SetMasterVolumeFromSlider()
    {
        masterVolume.SetFloat("MasterVolume", soundSlider.value*100-80);
        
    }
    public void SetMusicVolumeFromSlider()
    {
        masterVolume.SetFloat("MusicVolume", MusicSlider.value * 100 - 80);

    }
    public void SetSfxVolumeFromSlider()
    {
        masterVolume.SetFloat("SFXVolume", SFXSlider.value * 100 - 80);

    }
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (paused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    
    void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        paused = false; 
    }
    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
}
