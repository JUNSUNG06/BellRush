using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public Vector2 slideColSize;

    private BoxCollider2D col;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();

        GetComponent<PlayerInput>().slideAction += Slidding;
    }

    private void Update()
    {
        /*if(Input.GetMouseButton(1))
        {
            Slidding();
        }*/
    }

    public void Slidding()
    {
        col.size = slideColSize;
    }
}
