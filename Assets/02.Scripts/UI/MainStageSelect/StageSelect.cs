using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public AudioClip bellSound;

    public void PlayBtn()
    {
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
}
