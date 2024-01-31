using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;

    public GameState GameState;
    public HealthBar healthBar;
    public float maxHealth = 3;
    public float currentHealth;

    public bool isMoving;


    public void Start(){

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void FixedUpdate(){
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed , y:0 , _joystick.Vertical * _moveSpeed);

        if(_joystick.Horizontal !=0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("Move" , true);
            _animator.SetBool("Slash" , false);
            isMoving = true;
        }
        else
        {
            _animator.SetBool("Move" , false);
            _animator.SetBool("Slash" , true);
            isMoving = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(float value){
        
        if (currentHealth == 1)
        {
            GameState.GameOver();
        }
        currentHealth -= value;
        healthBar.SetHealth(currentHealth);
    }
}
