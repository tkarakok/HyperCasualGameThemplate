using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerJoystickController))]
[RequireComponent(typeof(PlayerAnimationController))]
[RequireComponent(typeof(PlayerCollisionController))]
[RequireComponent(typeof(Player))]
public class PlayerMovementController : MovementController
{
    private PlayerData _playerData;
    PlayerJoystickController _playerJoystickController;
    PlayerAnimationController _playerAnimationController;

    bool _stopping;
    bool _walk;

    public bool Stopping { get => _stopping; set => _stopping = value; }

    public void Start()
    {
        _playerJoystickController = GetComponent<PlayerJoystickController>();
        _playerAnimationController = GetComponent<PlayerAnimationController>();
        _playerData = GetComponent<PlayerData>();
    }
    
    public void Update()
    {
        if (StateManager.Instance.GetCurrentState() != State.InGame) return;
        _playerJoystickController.SetInput(_playerJoystickController.FloatingJoystick);
    }

    private void FixedUpdate()
    {
        if (StateManager.Instance.GetCurrentState() != State.InGame) return;
        _playerJoystickController.Rotate();
        Move();
    }

    public void Move()
    {
        Vector3 direction = (Vector3.forward * (_playerJoystickController.vertical) + Vector3.right * (_playerJoystickController.horizontal));
        transform.position += direction * _playerData.Speed;

        if (direction != Vector3.zero)
        {
            if( _playerAnimationController.GetWalk() == 0)
            {
                _playerAnimationController.SetWalkForBug();
            };
            if (!Stopping) return;
            Stopping = false;
            _playerAnimationController.SetWalk();
        }
        else
        {
            if (Stopping) return;
            Stopping = true;
            _playerAnimationController.SetIdle();
        }
    }
}
