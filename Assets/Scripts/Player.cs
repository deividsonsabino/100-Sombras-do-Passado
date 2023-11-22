using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 8.0f;

    private Vector2 moveDirection;

    private Vector3 input;

    private CharacterController character;

    void Awake()
    {
        character = GetComponent<CharacterController>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    void Update()
    {
        character.Move(transform.TransformDirection(new Vector3(moveDirection.x,-1,moveDirection.y)).normalized * Time.deltaTime * moveSpeed);
    }
}
