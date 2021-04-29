using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _moveInput;
    public float Speed;
    public float JumpForce;
    private float _currentJumpTime;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * JumpForce;
        }

    }

    private void FixedUpdate()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2((_moveInput * Speed) * Time.fixedDeltaTime, _rb.velocity.y);
    }
}
