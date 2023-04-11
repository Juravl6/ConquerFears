using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip winAudio;

    public void PlayWinClip()
    {
        audioSource.PlayOneShot(winAudio);
    }
        
   
}
