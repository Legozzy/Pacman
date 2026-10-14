using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class GridMovement : MonoBehaviour
{

    private bool isMoving;
    private Vector3 originalPosition;
    private Vector3 targetlPosition;
    private float timeToMove = .2f;


    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector2 moveVector = new Vector2(0, 0);

        if (Keyboard.current.wKey.isPressed && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.up));
        }

        if (Keyboard.current.sKey.isPressed && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.down));
        }

        if (Keyboard.current.aKey.isPressed && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }

        if (Keyboard.current.dKey.isPressed && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right));
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        originalPosition = transform.position;

        targetlPosition = originalPosition + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(originalPosition, targetlPosition, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetlPosition;

        isMoving = false;
    }

}
