using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 5f;

    [SerializeField]
    private float _rotationSpeed = 10f;

    [SerializeField]
    private Camera _followCamera;

    void Update()
    {      
        movement();
    }

    void movement(){
        directionMovement();
        upDownMovement();
    } 

    void directionMovement(){
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movementInput = Quaternion.Euler(0,_followCamera.transform.eulerAngles.y ,0) * new Vector3(horizontalInput, 0, verticalInput);
        Vector3 movementDirection = movementInput.normalized;

        transform.Translate(movementDirection * _playerSpeed * Time.deltaTime);
    }

    void upDownMovement(){
        float verticalInput = Input.GetAxis("Vertical1");

        Vector3 movementInput = Quaternion.Euler(0,_followCamera.transform.eulerAngles.y ,0) * new Vector3(0, verticalInput, 0);
        Vector3 movementDirection = movementInput.normalized;

        transform.Translate(movementDirection * _playerSpeed * Time.deltaTime);
    }

}
