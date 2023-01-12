using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private void Update()
    {
        LoadMainScene();
    }

    private void LoadMainScene()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
