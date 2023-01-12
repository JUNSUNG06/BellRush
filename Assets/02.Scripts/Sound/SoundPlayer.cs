using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    AudioSource maudio;
    public AudioClip clickSound;

    private void Awake()
    {
        maudio = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        maudio.PlayOneShot(clickSound);
    }

    public void PlaySound(AudioClip clip)
    {
        maudio.PlayOneShot(clip);
    }
}
