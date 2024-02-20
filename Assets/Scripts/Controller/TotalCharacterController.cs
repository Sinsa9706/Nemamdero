using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalCharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnRunEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallRunEvent(Vector2 direction)
    {
        OnRunEvent?.Invoke(direction);
    }
}
