using System.Collections;
using System.Collections.Generic;
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
/*         input.Set(moveDirection.x, 0, moveDirection.y);
        character.Move(input * Time.deltaTime * moveSpeed);
        character.Move(Vector3.down * Time.deltaTime);
        if (input != Vector3.zero) {
            transform.forward = Vector3.Slerp(transform.forward, input, Time.deltaTime * 10);
        } */
    }

    private void movePlayer(Vector3 direction)
    {
        //transform.position = new Vector3(direction.x, 0f, direction.y) * moveSpeed * Time.deltaTime;
        //transform.rotation = Quaternion.AngleAxis(Camera.main.transform.eulerAngles.y, Vector2.up);

    }

    /*     private void FixedUpdate()
        {
            movePlayer(moveDirection);
        } */
}
