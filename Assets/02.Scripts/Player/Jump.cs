using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpHeight;
    public int jumpNumber;
    public bool isJump;
    public float groundCheckOffset;
    public float groundCheckRadius;
    public LayerMask groundLayer;

    public int jumpCount = 0;

    private Rigidbody2D rb;
    private PlayerAnim anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<PlayerInput>().jumpAction += Jumping;
        anim = GetComponent<PlayerAnim>();
    }

    private void Update()
    {
        ResetJumpCount();
    }

    public void Jumping()
    {
        if(jumpCount < jumpNumber)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Sqrt((float)(2 * 9.81 * jumpHeight)));
            isJump = true;
            jumpCount++;
        }       
    }

    private bool CheckGround()
    {
        RaycastHit2D ray = Physics2D.CircleCast(new Vector2(transform.position.x, transform.position.y - groundCheckOffset)
            , groundCheckRadius, Vector2.zero, 1, groundLayer);

        return ray.collider;
    }

    private void ResetJumpCount()
    {
        if(CheckGround())
        {
            if(jumpCount > 0 && rb.velocity.y < 0f)
            {
                jumpCount = 0;
                isJump = false;
                anim.SetRunAnim();
            }
        }     
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(new Vector2(transform.position.x, transform.position.y - groundCheckOffset), groundCheckRadius);
    }
#endif
}
