using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public AudioClip clickSound;
    public SoundPlayer s;
    private bool isClicked = false;

    private void Update()
    {
        LoadMainScene();
    }

    private void LoadMainScene()
    {
        if(Input.anyKeyDown && !isClicked)
        {
            isClicked = true;
            s.PlayClickSound();
            FadeManager.Instance.FadeOut(() => SceneManager.LoadScene("Main"));
        }
    }
}
