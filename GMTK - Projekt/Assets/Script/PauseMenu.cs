using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] AudioMixer masterVolume;
    [SerializeField] Slider MasterSlider;
    [SerializeField] Slider SFXSlider;
    [SerializeField] Slider MusicSlider;


    public static bool paused = false;

    public GameObject pauseMenuUi;
    private float localTimeScale;
    //THis is not the Sound Menu but the other one
    public GameObject MainPauseMenu;
    public GameObject SoundMenu;
    public void Awake()
    {
        pauseMenuUi.SetActive(true);
        float masterVol = PlayerPrefs.GetFloat("MasterVolume");
        float musicVol = PlayerPrefs.GetFloat("MusicVolume");
        float SFXVol = PlayerPrefs.GetFloat("SFXVolume");
        masterVolume.SetFloat("MasterVolume", masterVol);
        masterVolume.SetFloat("MusicVolume", musicVol);
        masterVolume.SetFloat("SFXVolume", SFXVol);
        MasterSlider.value = (masterVol / 40) + 1;
        MusicSlider.value = (musicVol / 40) + 1;
        pauseMenuUi.SetActive(false);

    }
    public void GetAudioMixerVolume()
    {
        //Set the slider to the Value of the Master Mixer 
        float masterValue;
        bool masterMixer = masterVolume.GetFloat("MasterVolume", out masterValue); ;
        MasterSlider.value = (masterValue / 40) + 1;

        float sfxValue;
        bool sfxMixer = masterVolume.GetFloat("SFXVolume", out sfxValue); ;
        SFXSlider.value = (sfxValue / 40) + 1;

        float musicValue;
        bool musicMixer = masterVolume.GetFloat("SFXVolume", out musicValue); ;
        MusicSlider.value = (musicValue / 40) + 1;

    }
    public void SetMasterVolumeFromSlider()
    {
        float value = 0 - (1 - MasterSlider.value) * 40;      
        //Mute the audio if the slider is all the way to the left
        if (value == -40)
        {
            value = -80;
        }
        masterVolume.SetFloat("MasterVolume", value);
        PlayerPrefs.SetFloat("MasterVolume", value);
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
        PlayerPrefs.SetFloat("MusicVolume", value);

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
        PlayerPrefs.SetFloat("SFXVolume", value);

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
                    SoundMenu.SetActive(false);
                    MainPauseMenu.SetActive(true);
                    Pause();
                }
            }
        }
    
    public void Resume()
    {       
        pauseMenuUi.SetActive(false);
        Time.timeScale = localTimeScale;      
        paused = false; 
    }
    public void Pause()
    {
        localTimeScale = Time.timeScale;
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void Menu()
    {
        StatManager.Instance.ResetValues();
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        Invoke("loadMenu",0.15f);
    }
    private void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
