using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    CharacterController _controller;

    [SerializeField]
    float _moveSpeed = 5.0f;

    [SerializeField]
    float _jumpSpeed = 20.0f;

    [SerializeField]
    float _gravity = 20.0f; // Yer�ekimi de�erini art�r�yoruz

    float _yVelocity = 0.0f;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * _moveSpeed;

        if (_controller.isGrounded)
        {
            // Yer�ekimi de�erini art�rmak i�in bir e�ik de�eri kullan�yoruz.
            if (_yVelocity < 0)
            {
                _yVelocity = -1f;
            }

            if (Input.GetButtonDown("Jump"))
            {
                _yVelocity = _jumpSpeed;
            }
        }
        else
        {
            _yVelocity -= _gravity * Time.deltaTime; // Yer�ekimi miktar�n� zamanla �arp�yoruz
        }

        velocity.y = _yVelocity;

        _controller.Move(velocity * Time.deltaTime);
    }
}
