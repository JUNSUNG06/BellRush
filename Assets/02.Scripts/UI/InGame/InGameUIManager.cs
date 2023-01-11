using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUIManager : MonoBehaviour
{
    public GameObject activePanel;

    public void ActivePanel(GameObject panel)
    {
        activePanel.SetActive(false);
        activePanel = panel;
        activePanel.SetActive(true);
    }
}
