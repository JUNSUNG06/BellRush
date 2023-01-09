using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WorldMap : MonoBehaviour
{
    public Transform playerImgTrm;

    private Vector3 originPos;

    private void Start()
    {
        originPos = transform.position;
    }

    public void SetPos(Vector3 countryPos)
    {
        Vector3 moveAmount = originPos - countryPos;
        transform.DOMove(playerImgTrm.position + moveAmount, 0.5f);
    }
}
