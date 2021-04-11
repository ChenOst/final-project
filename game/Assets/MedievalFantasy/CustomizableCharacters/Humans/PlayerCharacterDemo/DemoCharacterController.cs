using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCharacterController : MonoBehaviour {

    public static DemoCharacterController instance;
    private void Awake() {
        instance = this;
    }
    Animator anim;
    PlayerCharacter player;
    CharacterController cc;

    private float movementSpeed;

    public float walkSpeed = 1.5f;
    public float runSpeed = 4;
    public float rotationSpeed = 10;

    [SerializeField]
    private Transform _groundCheck;
    [SerializeField]
    private LayerMask _groundMask;

    private float _gravity = -9.81f;
    private float _groundDistance = 0.4f;
    private Vector3 _velovity;
    private bool _isGrounded;

    public void PickupItem(int itemId) {
        player.EquipItem(itemId);
    }




    void Start() {
        player = GetComponent<PlayerCharacter>();
        anim = player.animator;
        cc = GetComponent<CharacterController>();

        player.EquipItem(37);
        player.EquipItem(38);
        player.EquipItem(249);
        player.EquipItem(257);
    }

    void Update() {

        Vector3 movementDirection = UpdateInput();

        if (movementDirection != Vector3.zero) {
            cc.Move((transform.forward * movementSpeed) * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), Time.deltaTime * rotationSpeed); // rotate character to movement direction
        } else {
            cc.Move(Vector3.zero);
        }
        anim.SetFloat("MovementSpeed", cc.velocity.magnitude); // play idle/walk/run animation

        // Make sure that the player will stay on ground
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && _velovity.y < 0)
        {
            _velovity.y = -2f;
        }

        _velovity.y += _gravity * Time.deltaTime;
        cc.Move(_velovity * Time.deltaTime);
    }


    Vector3 UpdateInput() {
        Vector3 movementDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            movementDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            movementDirection += -Vector3.forward;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            movementDirection += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            movementDirection += -Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftShift)) {
            movementSpeed = runSpeed;
        } else {
            movementSpeed = walkSpeed;
        }
        return movementDirection;
    }



}
