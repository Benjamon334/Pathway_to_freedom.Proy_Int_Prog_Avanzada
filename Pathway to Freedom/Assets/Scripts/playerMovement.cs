using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField ]public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized;

        transform.Translate(movement * moveSpeed * Time.deltaTime);
        */

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = movement.normalized * moveSpeed;
        // CheckForFlipping(); 

        if (movement.x != 0 || movement.y != 0)
        {
            SetAnimatorMovement(movement);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }

    }

    /*
    private void CheckForFlipping()
    {
        bool movingLeft = movement.x < 0;
        bool movingRight = movement.x > 0;

        if(movingLeft)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y);
        }
        if(movingRight)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y);
        }
    }
    */
    
    private void SetAnimatorMovement(Vector2 movement)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", movement.x);
        animator.SetFloat("yDir", movement.y);
    }

}
