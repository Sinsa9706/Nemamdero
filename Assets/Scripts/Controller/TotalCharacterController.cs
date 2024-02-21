using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action OnRunEvent;
    public event Action OnRunStopEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallRunEvent()
    {
        OnRunEvent?.Invoke();
    }

    public void CallRunStopEvent()
    {
        OnRunStopEvent?.Invoke();
    }
}