using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TotalCharacterController
{
    private Camera _Camera;

    private void Awake()
    {
        _Camera = Camera.main;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>().normalized;
        if(moveInput.x < 0)
        {
            CallLookLeftEvent(moveInput);
        }
        else if (moveInput.x > 0)
        {
            CallLookRightEvent(moveInput);
        }
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
