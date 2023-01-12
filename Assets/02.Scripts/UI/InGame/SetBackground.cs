using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = StageManager.Instance.stage.GetComponent<Stage>().backgroundImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
