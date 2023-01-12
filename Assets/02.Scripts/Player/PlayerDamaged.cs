using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamaged : MonoBehaviour
{
    public bool canHit = true;

    private Run runController;
    private SpriteRenderer sp;

    private void Start()
    {
        runController = GetComponent<Run>();
        sp = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacles"))
        {
            Hit();
        }
    }

    private void Hit()
    {
        if (!canHit) return;

        StartCoroutine(hit());
    }

    private IEnumerator hit()
    {
        sp.color = new Color(sp.color.r, sp.color.g, sp.color.b, 0.5f);
        runController.SetDecreaseSpeed(0.5f, 2f);
        canHit = false;

        yield return new WaitForSeconds(2f);

        sp.color = new Color(sp.color.r, sp.color.g, sp.color.b, 255);
        canHit = true;
    }
}
