using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private float _moveSpeed = 5f;
    private const string Coin    = "Coin";
    [SerializeField] private GameInput gameInput;
    
    public static Action OnCoinCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Coin))
        {
            OnCoinCollected?.Invoke();
            
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDirection = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position += moveDirection * (_moveSpeed * Time.deltaTime);
        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, rotateSpeed * Time.deltaTime);
    }
}