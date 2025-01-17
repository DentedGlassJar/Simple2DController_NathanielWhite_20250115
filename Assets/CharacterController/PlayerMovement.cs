using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputManager;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;

    public Vector2 moveDirection = new Vector2(0.00f, 0.00f);
    public float moveSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        Actions.MoveEvent += HandlePlayerMovement;
    }

    private void OnDisable()
    {
        Actions.MoveEvent -= HandlePlayerMovement;
    }

    void HandlePlayerMovement()
    {
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
