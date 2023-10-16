using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// author: Ines De Doncker
public class MagicCube : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    [SerializeField] float rotationSpeed = 50f;

    [SerializeField] float bounceFrequency = 1f;

    [SerializeField] float bounceHeight = 5f;

    [SerializeField] float growthRate = 2f;

    void Update()
    {
        MakeBounce();
        MakeRotate();
        MakeMove();
    }

    /**
     * - Makes GameObject move up and down according to sine wave.
     * - Makes GameObject grow when it moves up.
     * - Makes GameObject shrink when it moves down.
     */
    void MakeBounce()
    {
        float oldAltitude = transform.position.y;
        float newAltitude = bounceHeight * Mathf.Sin(bounceFrequency * 2f * Mathf.PI * Time.time);
        float scaleChange = (newAltitude >= oldAltitude ? 1 : -1) * growthRate;

        transform.localScale += Vector3.one * scaleChange * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, newAltitude, transform.position.z);
    }

    /**
     * Makes GameObject moveable within the World space.
     */
    void MakeMove()
    {
        float moveForward = Input.GetAxis("Vertical");
        float moveRight = Input.GetAxis("Horizontal");

        Vector3 newDirection = (Vector3.right * moveRight) + (Vector3.forward * moveForward);

        transform.Translate(newDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    /**
     * Makes GameObject rotate along its Y-axis.
     */
    void MakeRotate()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
