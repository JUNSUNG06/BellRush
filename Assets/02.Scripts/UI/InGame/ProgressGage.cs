using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressGage : MonoBehaviour
{
    private Slider progressSlider;
    private Transform finishPos;
    private Transform startPos;
    private Transform playerPos;

    private float stageLength;

    private void Start()
    {
        progressSlider = GetComponent<Slider>();
        finishPos = StageManager.Instance.stage.transform.Find("Positions/FinishPos");
        startPos = StageManager.Instance.stage.transform.Find("Positions/InitPos/PlayerInitPos");
        playerPos = GameObject.Find("Player").GetComponent<Transform>();

        stageLength = finishPos.position.x - startPos.position.x;
    }

    private void Update()
    {
        SetSliderGage();
    }

    private void SetSliderGage()
    {
        float progress = playerPos.position.x - startPos.position.x;    
        float progressValue = progress / stageLength;
        progressSlider.value = progressValue;
    }
}
