using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public Vector2 slideColSize;

    private BoxCollider2D col;
    private Vector2 originColSize;
    private Vector2 originColOffset;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();

        GetComponent<PlayerInput>().slideAction += Slidding;
        originColSize = col.size;
        originColOffset = col.offset;
    }

    public void Slidding()
    {
        col.size = slideColSize;
        col.offset = new Vector2(0, -(originColSize.y - slideColSize.y) / 2);
    }

    public void SetColliderOrigin()
    {
        col.size = originColSize;
        col.offset = originColOffset;
    }
}
