using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private Transform _groundCheck;

    [SerializeField]
    private LayerMask _groundMask;

    [SerializeField]
    private float _walkSpeed = 1.5f;

    [SerializeField]
    private float _runSpeed = 4;

    [SerializeField]
    private float _rotationSpeed = 10;

    private PlayerCharacter _player;

    private CharacterController _cc;

    private Animator _anim;

    private float _movementSpeed;

    private float _gravity = -9.81f;

    private float _groundDistance = 0.4f;

    private Vector3 _velovity;

    private bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<PlayerCharacter>();
        _cc = GetComponent<CharacterController>();
        _anim = _player.animator;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementDirection = UpdateDirection();

        // Move and Rotate the player
        if (movementDirection != Vector3.zero)
        {
            _cc.Move(movementDirection * _movementSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), Time.deltaTime * _rotationSpeed); // rotate character to movement direction
        }
        else
        {
            _cc.Move(Vector3.zero);
        }

        // Play idle/walk/run animation
        _anim.SetFloat("MovementSpeed", _cc.velocity.magnitude);

        // Check if player is walking on the ground
        OnGroundCheck();
    }

    Vector3 UpdateDirection()
    {
        Vector3 movementDirection = Vector3.zero;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movementDirection.x += x;
        movementDirection.z += z;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _movementSpeed = _runSpeed;
        }
        else
        {
            _movementSpeed = _walkSpeed;
        }
        return movementDirection;
    }

    void OnGroundCheck()
    {
        // Make sure that the player will stay on ground
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && _velovity.y < 0)
        {
            _velovity.y = -2f;
        }

        _velovity.y += _gravity * Time.deltaTime;
        _cc.Move(_velovity * Time.deltaTime);
    }
}
