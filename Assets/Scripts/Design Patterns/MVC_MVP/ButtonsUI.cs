using UnityEngine;
using UnityEngine.UI;

public class ButtonsUI : MonoBehaviour
{
    [Header("MVP REFERENCES")]
    [SerializeField] private HealthPresenter healthPresenter;
    
    [Header("UI REFERENCES")]
    [SerializeField] private Button damageButton;
    [SerializeField] private Button healButton;

    private int damageAmount = 10;
    private int healAmount = 10;

    private void Awake()
    {
        damageButton.onClick.AddListener(() =>
        {
            healthPresenter?.OnDamageButtonClick(damageAmount);
        });

        healButton.onClick.AddListener(() =>
        {
            healthPresenter?.OnHealButtonClick(healAmount);
        });
    }
}