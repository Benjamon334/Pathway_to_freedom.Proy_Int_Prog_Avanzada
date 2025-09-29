using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrototype : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
    float moveY = Input.GetAxisRaw("Vertical");

    Vector2 movement = new Vector2(moveX, moveY).normalized;

    transform.Translate(movement * moveSpeed * Time.deltaTime);
        
    }

}
