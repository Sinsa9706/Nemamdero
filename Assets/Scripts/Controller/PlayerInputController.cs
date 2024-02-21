using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TotalCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
            Vector2 moveInput = context.ReadValue<Vector2>().normalized;
            Debug.Log(context.ReadValue<Vector2>());
            CallMoveEvent(moveInput);
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            CallRunEvent();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            CallRunStopEvent();
        }
    }
}
