using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{
    public static event Action<Vector2> OnMovement;
    public void Movement(InputAction.CallbackContext context)
    {
        OnMovement?.Invoke(context.ReadValue<Vector2>());   
    }
}
