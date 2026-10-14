using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pacman : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector2 moveVector = new Vector2(0, 0);

        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            transform.Rotate(Vector3.up);
        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            transform.Rotate(Vector3.down);
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            transform.Rotate(Vector3.left);
        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            transform.Rotate(Vector3.right);
        }

        //transform.position += (Vector3)moveVector * movementSpeed * Time.deltaTime;
    }

}
