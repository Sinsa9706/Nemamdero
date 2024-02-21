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

    private TotalCharacterController _Controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _Rigidbody;
    private SpriteRenderer _PlayerSpriteRenderer;

    private void Awake()
    {
        _Controller = GetComponent<TotalCharacterController>();
        _Rigidbody = GetComponent<Rigidbody2D>();
        _PlayerSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        speed = basespeed;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Start()
    {
        _Controller.OnMoveEvent += Move;
        _Controller.OnRunEvent += Run;
        _Controller.OnRunStopEvent += RunStop;
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
        _PlayerSpriteRenderer.flipX = direction.x < 0;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;

        _Rigidbody.velocity = direction;
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
