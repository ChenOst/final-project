using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

    [SerializeField]
    private float _lookRadius = 4f;

    [SerializeField]
    private float _movementSpeed = 1f;

    [SerializeField]
    private float _rotationSpeed = 2f;

    Transform target;

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find(Constants.Player).transform;
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        Vector3 direction = target.position - transform.position;
        RaycastHit hit;

        if (distance <= _lookRadius)
        {
            // Rotate enemy body torwards direction 
            if (direction != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * _rotationSpeed);
            }
          
            if (Physics.Raycast(transform.position, direction + new Vector3(0,1,0), out hit, 4.5f))
            {
                if (hit.collider.gameObject.tag == Constants.PlayerTag)
                {
                    // The enemy is close to the player and can attack
                    if (distance <= 1f)
                    {
                        _anim.SetFloat("MovementSpeed", 0);
                        _anim.SetBool("CanAttack", true);
                    }
                    // The enemy need to get closer to the player - walk 
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position, target.position, _movementSpeed * Time.deltaTime);
                        _anim.SetBool("CanAttack", false);
                        _anim.SetFloat("MovementSpeed", 1);
                    }
                }
            }
        }
        // run the idle animation if the player is not in look radius
        else
        {
            _anim.SetBool("CanAttack", false);
            _anim.SetFloat("MovementSpeed", 0);
        }
        
    }
}
