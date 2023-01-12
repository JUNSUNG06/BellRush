using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector2 offset;
    public GameObject player;

    private float playerY;

    private void Start()
    {
        playerY = player.transform.position.y;
    }
    private void Update()
    {
        transform.position = new Vector2(player.transform.position.x + offset.x, player.transform.position.y + offset.y);
    }
}
