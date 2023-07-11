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

    public void Awake()
    {
        pauseMenuUi.SetActive(true);
        SetMasterVolumeFromSlider();
        SetMusicVolumeFromSlider();
        SetSfxVolumeFromSlider();
        pauseMenuUi.SetActive(false);

    }

    public void SetMasterVolumeFromSlider()
    {
        float value = 0 - (1 - soundSlider.value) * 40;      
        //Mute the audio if the slider is all the way to the left
        if (value == -40)
        {
            value = -80;
        }
        masterVolume.SetFloat("MasterVolume", value);
    }
    public void SetMusicVolumeFromSlider()
    {
        float value = 0 - (1 - MusicSlider.value) * 40;
        //Mute the audio if the slider is all the way to the left
        if (value == -40)
        {
            value = -80;
        }
        masterVolume.SetFloat("MusicVolume", value);

    }
    public void SetSfxVolumeFromSlider()
    {
        float value = 0 - (1 - SFXSlider.value) * 40;
        //Mute the audio if the slider is all the way to the left
        if (value == -40)
        {
            value = -80;
        }
        masterVolume.SetFloat("SFXVolume", value);

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
