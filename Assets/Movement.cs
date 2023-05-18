using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");

        playerDirection = new Vector2(directionX, directionY).normalized;

        animator.SetFloat("Horizontal", directionX);
        animator.SetFloat("Vertical", directionY);
        animator.SetFloat("Speed",  playerDirection.sqrMagnitude);
    }

void FixedUpdate(){
    rb.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
}

}
