using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    public int stageIndex;

    public void ClearStage()
    {
        PlayerPrefs.SetInt($"ClearStage{stageIndex}", 1);
        Debug.Log("clear");
    }
}
