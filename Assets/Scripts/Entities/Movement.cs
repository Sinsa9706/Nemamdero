using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("이동속도")]
    public float basespeed = 5;
    [Header("달리기속도")]
    public float runspeed;

    private float speed;

    private TotalCharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TotalCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        speed = basespeed;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnRunEvent += Run;
        _controller.OnRunStopEvent += RunStop;
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;

        _rigidbody.velocity = direction;
    }

    private void Run()
    {
        speed = runspeed;
    }

    private void RunStop()
    {
        speed = basespeed;
    }
}
