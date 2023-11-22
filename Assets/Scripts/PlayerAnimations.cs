using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private InputActionReference XYAxis;

    private Vector3 inputs;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        inputs.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector2 inputValues = XYAxis.action.ReadValue<Vector2>();
        animator.SetFloat("Horizontal", inputValues.x);
        animator.SetFloat("Vertical", inputValues.y);
        if (inputs != Vector3.zero)
        {
            animator.SetBool("IsWalk", true);
        } else {
            animator.SetBool("IsWalk", false);
        }
    }
}
