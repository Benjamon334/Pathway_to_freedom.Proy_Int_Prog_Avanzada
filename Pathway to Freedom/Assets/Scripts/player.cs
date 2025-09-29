using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
            transform.localScale = new Vector3(-1, 1, 1); // Flip the sprite to face left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
            transform.localScale = new Vector3(1, 1, 1); // Face right
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            anim.SetBool("isWalking", false);
        }
    }
}
