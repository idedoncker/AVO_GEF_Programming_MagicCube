using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 1f; // horizontal speed

    [SerializeField] bool includeGravity = false;

    void Update()
    {
        // Moves GameObject forward without user input.

        // transform.position += transform.forward * speed * Time.deltaTime;

        // -------------------------------------------------------------------------------------
        // Moves GameObject according to user input.

        float moveForward = Input.GetAxis("Vertical"); // -1 (ArrowDown), 0 or 1 (ArrowUp)
        float moveRight = Input.GetAxis("Horizontal"); // -1 (ArrowLeft), 0 or 1 (ArrowRight)

        // transform.Translate(Vector3.forward * speed * moveForward * Time.deltaTime);
        // transform.Translate(Vector3.right * speed * moveRight * Time.deltaTime);

        // -------------------------------------------------------------------------------------
        // Moves GameObject according to user input in a more efficient way.

        Vector3 newDirection = (Vector3.right * moveRight) + (Vector3.forward * moveForward);

        if (includeGravity)
        {
            Vector3 gravity = Physics.gravity;
            newDirection += gravity; // no collision detection yet
        }

        transform.Translate(newDirection * speed * Time.deltaTime); // only 1 execution of Translate
    }
}