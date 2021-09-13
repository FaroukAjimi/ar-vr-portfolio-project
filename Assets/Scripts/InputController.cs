using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;



[Serializable]
public class MoveInputEvent : UnityEvent<float, float> { }


public class InputController : MonoBehaviour
{
    PlayerActions controls;
    public MoveInputEvent moveInputEvent;

    private void Awake()
    {
        controls = new PlayerActions();
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.Gameplay.Move.performed += OnMovePerformed;
        controls.Gameplay.Move.canceled += OnMovePerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
        //Debug.Log($"Move Input: {moveInput}");
    }
}
