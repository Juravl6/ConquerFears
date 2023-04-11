using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(inputX, 0);
        rb.velocity = direction * speed;
    }
}
