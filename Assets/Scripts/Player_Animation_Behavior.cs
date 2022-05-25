using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation_Behavior : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementBehaviour _playerMovement;
    [SerializeField]
    private Animator _animator;

    private void Awake()
    {
        WinBoxBehaviour.OnWin += () => _animator.SetTrigger("Win");
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("speed", _playerMovement.Velocity.magnitude);

        _animator.SetBool("IsGrounded", _playerMovement.IsGrounded);
    }
}
