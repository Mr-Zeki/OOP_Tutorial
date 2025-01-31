using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    
    public static PlayerController1 Instance;
    [Header("References")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private GameInput gameInput;
    public Animator animator;


    [Header("Settings")]
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody playerRigidbody;
    private IState currentState;

    private bool isWalking;
    private bool isGrounded;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        Instance = this;
        playerRigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        currentState = new IdleState();
        currentState.EnterState(this);
    }
    private void Update()
    {
        currentState.UpdateState(this);
        //animator.SetTrigger("Idle");
        
    }

    public void ChangeState(IState newState)
    {
        currentState.ExitState(this);
        currentState = newState;
        currentState.EnterState(this);
    }


    public void HandlePlayerMovement()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        isWalking = moveDirection != Vector3.zero;
        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotateSpeed * Time.deltaTime);
    }

    public void HandleJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }
    }

    public bool IsGrounded()
    {
        float sphereRadius = 0.1f;
        isGrounded = Physics.CheckSphere(transform.position, sphereRadius, groundLayer);
        return isGrounded;
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
