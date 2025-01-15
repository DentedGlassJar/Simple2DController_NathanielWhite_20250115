using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class InputManager : MonoBehaviour, GameInput.IPlayerActions
{
    private GameInput gameInput;

    void Awake()
    {
        gameInput = new GameInput();

        gameInput.Player.Enable();

        gameInput.Player.SetCallbacks(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Receiving Move Input : " + context.ReadValue<Vector2>());
        }


    }

    public static class Actions
    {
        public static Action<Vector2> MoveEvent; 
    }
}
