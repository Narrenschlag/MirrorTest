using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using Mirror;

public class Player : NetworkBehaviour
{
    [Header("Movement")]
    public float MOVEMENT_SPEED = .5f;

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float _moveX = Input.GetAxis("Horizontal");
            float _moveY = Input.GetAxis("Vertical");

            Vector3 _move = new Vector3(_moveX, 0, _moveY);
            transform.position += _move * MOVEMENT_SPEED * Time.deltaTime;
        }
    }
}