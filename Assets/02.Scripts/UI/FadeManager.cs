using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class FadeManager : MonoBehaviour
{
    public static FadeManager Instance;
    public Image fadeImage;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        
    }

    public void FadeIn()
    {
        fadeImage.DOColor(new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 0f), 3f).OnComplete(() => fadeImage.gameObject.SetActive(false));
    }

    public void FadeIn(Action action)
    {
        fadeImage.DOColor(new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 0f), 3f).OnComplete(() => action?.Invoke());
    }
    
    public void FadeOut()
    {
        fadeImage.gameObject.SetActive(true);  
        fadeImage.DOColor(new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1f), 3f);
    }

    public void FadeOut(Action action)
    {
        fadeImage.gameObject.SetActive(true);
        fadeImage.DOColor(new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1f), 3f).OnComplete(() => action?.Invoke());
    }
}
