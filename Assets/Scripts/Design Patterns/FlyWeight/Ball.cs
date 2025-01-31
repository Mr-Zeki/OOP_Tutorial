
using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private BallStateSO ballStateSO;
    [SerializeField] private int currentHealth;
    [SerializeField] private float frictionAmount;
    void Start()
    {
        currentHealth = Random.Range(10, ballStateSO.MaxHealth);
        frictionAmount = Random.Range(1, ballStateSO.MaxFriction);
    }

    private Rigidbody ballRigidbody;
    private Renderer ballRenderer;
    private void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRenderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        ballRigidbody.AddForce(transform.forward * ballStateSO.ForceMagnitude, ForceMode.Impulse);

        if (ballRenderer != null)
        {
            ballRenderer.material.color = Random.ColorHSV();
        }
    }




}
