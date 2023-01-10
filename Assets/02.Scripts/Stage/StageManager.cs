using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance;

    public GameObject stage;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(Instance.gameObject);

        CreateStage();
    }

    private void CreateStage()
    {
        stage = Resources.Load<GameObject>($"Prefabs/Stages/Stage{PlayerPrefs.GetInt("Stage Index")}");
        Instantiate(stage, Vector2.zero, Quaternion.identity);

        SetPos();
    }

    private void SetPos()
    {
        GameObject.Find("Player").GetComponent<Transform>().position = stage.transform.Find("Positions/InitPos/PlayerInitPos").position;
        stage.transform.Find("Boss").GetComponent<Transform>().position = stage.transform.Find("Positions/InitPos/BossInitPos").position;
    }
}
