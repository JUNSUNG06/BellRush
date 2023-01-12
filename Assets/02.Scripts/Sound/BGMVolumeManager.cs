using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMVolumeManager : MonoBehaviour
{
    public static BGMVolumeManager Instance;

    private AudioSource BGMAudio;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        BGMAudio = GetComponent<AudioSource>();
    }

    public void LouderBGM()
    {
        StartCoroutine(setVolume(1f));
    }


    public void SmallerBGM()
    {
        StartCoroutine(setVolume(0f));
    }

    private IEnumerator setVolume(float endValue)
    {
        while(BGMAudio.volume == endValue)
        {
            BGMAudio.volume = Mathf.Lerp(BGMAudio.volume, endValue, Time.fixedDeltaTime * 10f);
            BGMAudio.volume = Mathf.Clamp(BGMAudio.volume, 0f, 1f);

            yield return null;
        }
    }
}
