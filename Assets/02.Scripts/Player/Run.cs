using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float originMoveSpeed;

    private float moveSpeed;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        ResetSpeed();
        SetVelocity();
    }

    private void Update()
    {
        SetVelocity();
    }

    private void ResetSpeed()
    {
        moveSpeed = originMoveSpeed;
    }

    private void SetVelocity()
    {
        Vector2 moveVector = new Vector2(moveSpeed, rb.velocity.y);

        rb.velocity = moveVector;
    }

    public void SetDecreaseSpeed(float decreaseAmount, float duration)
    {
        StartCoroutine(DecreaseSpeed(decreaseAmount, duration));
    }

    private IEnumerator DecreaseSpeed(float decreaseAmount, float duration)
    {
        moveSpeed *= decreaseAmount;

        yield return new WaitForSeconds(duration);

        ResetSpeed();
    }
}
