using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 8.0f;

    private Vector2 moveDirection;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        rb.AddForce(new Vector3(moveDirection.x, 0, moveDirection.y) * moveSpeed);
    }

    private void movePlayer(Vector3 direction) { 
        rb.velocity = direction * moveSpeed * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        movePlayer(moveDirection);
    }
}
