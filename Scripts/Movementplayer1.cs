using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementplayer1 : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 3f;

    private float cameraAxisX = 0f;

    enum MovementTypes { Adelante, Atras };

    [SerializeField] MovementTypes movementType;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        switch (movementType)
        {
            case MovementTypes.Adelante:
                MoveForward();
                break;
            case MovementTypes.Atras:
                MoveBackward();
                break;

        }
    }
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void MoveBackward()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    public void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime);
    }
}
