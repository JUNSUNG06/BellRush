using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPanel : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject stageSelectPanel;
    public GameObject StorePanel;
    public GameObject ItemPanel;
    public GameObject TrophyPanel;
    public GameObject SettingPanel;
    public GameObject ActivePanel;

    private void Start()
    {
        ActivePanel = mainPanel;
    }

    public void SetPanelActive(GameObject panel)
    {
        ActivePanel.SetActive(false);
        ActivePanel = panel;
        ActivePanel.SetActive(true);
    }
}
