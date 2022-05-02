using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 movementVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(movementVector * Time.deltaTime * speed);
    }
}
