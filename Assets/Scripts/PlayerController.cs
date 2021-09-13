using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 280.0f;

    float horizontal;
    float vertical;

    private Transform cameraTransform;


    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        // Player movement
        Vector3 moveDirection = Vector3.forward * vertical + Vector3.right * horizontal;

        // Move accordingly to camera direction
        Vector3 projectedCameraForward = Vector3.ProjectOnPlane(cameraTransform.forward, Vector3.up);
        Quaternion rotationToCamera = Quaternion.LookRotation(projectedCameraForward, Vector3.up);

        moveDirection = rotationToCamera * moveDirection;

        // Camera rotation
        Quaternion rotationToMoveDirection = Quaternion.LookRotation(moveDirection, Vector3.up);

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationToCamera, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationToMoveDirection, rotationSpeed * Time.deltaTime);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void OnMoveInput(float horizontal, float vertical)
    {
        this.vertical = vertical;
        this.horizontal = horizontal;
        //Debug.Log($"Player Controller: Move Input: {vertical}, {horizontal}");
    }
}
