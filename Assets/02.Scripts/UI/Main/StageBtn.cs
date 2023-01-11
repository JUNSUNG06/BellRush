using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageBtn : MonoBehaviour
{
    public int stageIndex;
    private Button btn;
    private Image lockImgae;

    private void Start()
    {
        btn = GetComponent<Button>();
        lockImgae = transform.Find("LockImage").GetComponent<Image>();

        if (stageIndex == 1)
            return;

        if(PlayerPrefs.GetInt($"ClearStage{stageIndex - 1}", 0) == 1)
        {
            btn.interactable = true;
            lockImgae.gameObject.SetActive(false);
        }
        else
        {
            btn.interactable = false;
            lockImgae.gameObject.SetActive(true);
        }
    }
}
