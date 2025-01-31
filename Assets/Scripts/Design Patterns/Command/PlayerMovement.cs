using System;
using System.Collections;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string IsJumping = "isJumping";
    [SerializeField] private Animator animator;
    [SerializeField] private float moveDuration = 0.75f;

    

    public void HandleMovement(Vector3 movement)
    {
        Vector3 destination = transform.position + movement;
        StartCoroutine(AnimateMovement(destination));
        animator.SetTrigger(IsJumping);
    }

    private IEnumerator AnimateMovement(Vector3 destination)
    {
        float waitingSeconds = 0.25f;
        yield return new WaitForSeconds(waitingSeconds);
        transform.DOMove(destination, moveDuration).SetEase(Ease.OutQuart);
    }
}