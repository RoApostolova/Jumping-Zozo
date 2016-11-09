using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class DisableBackgroundMusic : MonoBehaviour
{

    public  AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    public void Mute()
    {
        if (CrossPlatformInputManager.GetButton("Mute Button"))
        {
            // audio.Pause();

            if (audio.mute)
                audio.mute = false;
            else
                audio.mute = true;
        }
    }
}

