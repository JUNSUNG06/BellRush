using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public void PlayBtn()
    {
        SceneManager.LoadScene("Play");
    }

    public void SetStageIndex(int index)
    {
        PlayerPrefs.SetInt("Stage Index", index);
    }
}
