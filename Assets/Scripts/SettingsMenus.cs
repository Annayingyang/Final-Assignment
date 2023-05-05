using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenus : MonoBehaviour
{
    public AudioMixer masterSound;

    public void ChangeTheVolume(float soundVolume)
    {
        masterSound.SetFloat("GameVolume", soundVolume);
    }

    public void FullScreenToggle(bool screenFull)
    {
        Screen.fullScreen = screenFull;
    }
}
