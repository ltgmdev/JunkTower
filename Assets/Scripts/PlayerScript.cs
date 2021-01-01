using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, moveSpeed * Time.deltaTime);
        }
    }
}
