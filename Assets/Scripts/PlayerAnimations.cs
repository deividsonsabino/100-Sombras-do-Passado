using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private InputActionReference XYAxis;

    private void Start()
    {
       animator = GetComponent<Animator>(); 
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 inputValues = XYAxis.action.ReadValue<Vector2>();
        animator.SetFloat("Horizontal", inputValues.x);
        animator.SetFloat("Vertical", inputValues.y);
    }
}
