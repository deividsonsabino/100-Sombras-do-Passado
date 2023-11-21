using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private InputActionReference XYAxis;
    [SerializeField] private Transform lookAt;
    [SerializeField] private float sensitivity = 1.0f;

    private void Update()
    {
        Vector2 inputValues = XYAxis.action.ReadValue<Vector2>();
        inputValues *= sensitivity;

        lookAt.eulerAngles = new Vector3(inputValues.y, inputValues.x, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, inputValues.x, 0), 0.5f * Time.deltaTime);
    }
}
