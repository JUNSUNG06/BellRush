using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    public AudioClip bellSound;
    public Button button;
    private bool isClicked = false;


    public void PlayBtn()
    {
        BGMVolumeManager.Instance.SmallerBGM();
        button.interactable = false;
        FadeManager.Instance.FadeOut(() => StartCoroutine(PlayBellSoundAndLoadScene()));       
    }

    public void SetStageIndex(int index)
    {
        PlayerPrefs.SetInt("Stage Index", index);
    }

    private IEnumerator PlayBellSoundAndLoadScene()
    {
        transform.parent.GetComponent<SoundPlayer>().PlaySound(bellSound);

        yield return new WaitForSeconds(3.5f);

        SceneManager.LoadScene("Play");
    }

    public void IsClicked()
    {
        if(!isClicked)
        {
            isClicked = true;
        }
        else
            return;
    }
}
