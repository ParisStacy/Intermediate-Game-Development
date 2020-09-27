using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMove : MonoBehaviour
{
    [SerializeField]
    float force, jumpForce, groundedRayLength;

    Vector2 move;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        move = move.normalized;
        rb.gravityScale = (grounded) ? 1 : 10;

        rb.AddForce(move * force * Time.deltaTime, ForceMode2D.Impulse);
        spriteRenderer.flipX = (move.x > 0) ? true : false;

        RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(-.5f, 0, 0), Vector2.down, groundedRayLength);
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position - new Vector3(.5f, 0, 0), Vector2.down, groundedRayLength);
        grounded = (hit.collider != null || hit2.collider != null) ? true : false;

        if (Input.GetButtonDown("Jump") && grounded) rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
