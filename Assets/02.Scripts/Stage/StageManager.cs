using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance;

    [HideInInspector] public GameObject stage;
    public GameObject clearPanel;
    public GameObject gameOverPanel;
    public AudioClip clearSound;
    public AudioClip gameOverSound;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(Instance.gameObject);

        CreateStage();
    }

    private void Start()
    {
        FadeManager.Instance.FadeIn();
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

    public void Clear()
    {
        clearPanel.SetActive(true);
        stage.GetComponent<Stage>().ClearStage();
        GameObject.Find("Main Camera").GetComponent<AudioSource>().clip = clearSound;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().loop = false;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();
        GameObject.Find("Player").GetComponent<Run>().moveSpeed = 0;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<AudioSource>().clip = gameOverSound;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().loop = false;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();
        Debug.Log("game over");
    }
}