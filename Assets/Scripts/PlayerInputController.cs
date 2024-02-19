using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TotalCharacterController
{
    [Header("부스트 속도")][Range(1f, 10f)]
    public float speed = 1f;

    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnRun(InputValue value)
    {
        Debug.Log("OnRun" + value.ToString());
        // OnMove 
    }
}
