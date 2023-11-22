using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private AxisState xAxis;
    [SerializeField] private AxisState yAxis;

    [SerializeField] private Transform lookAt;

    void Update()
    {
        xAxis.Update(Time.deltaTime);
        yAxis.Update(Time.deltaTime);

        lookAt.eulerAngles = new Vector3(yAxis.Value, xAxis.Value, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, xAxis.Value, 0), 10 * Time.deltaTime);

    }
}
