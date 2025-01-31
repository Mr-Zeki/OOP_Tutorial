using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputs;

    private void Awake()
    {
        playerInputs = new PlayerInputActions();
        playerInputs.Player.Enable();

        playerInputs.Player.Jump.performed += PlayerJump;
    }

    private void PlayerJump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.ReadValueAsButton())
        {
            PlayerController1.Instance.HandleJump();
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputs.Player.Move.ReadValue<Vector2>();

        return inputVector;
    }

}
