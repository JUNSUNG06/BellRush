using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public AudioClip clickSound;
    public SoundPlayer s;

    private void Update()
    {
        LoadMainScene();
    }

    private void LoadMainScene()
    {
        if(Input.anyKeyDown)
        {
            StartCoroutine(SceneLoad());
        }
    }

    IEnumerator SceneLoad()
    {
        s.PlayClickSound();

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Main");
    }
}
