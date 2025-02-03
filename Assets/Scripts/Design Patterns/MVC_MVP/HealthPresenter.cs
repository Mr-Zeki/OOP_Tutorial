using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HealthPresenter : MonoBehaviour
{
    public event Action OnDamage;
    public event Action OnHeal;
    
    [SerializeField] private Health health;
    [SerializeField] private Slider healthSlider;

    private void Start()
    {
        health.OnHealthChanged += Health_OnHealthChanged;
        
        health.CurrentHealth = health.MaxHealth;
    }
    
    private void Health_OnHealthChanged() { UpdateView(); }

    public void UpdateView() 
    {
        if(health == null){ return; }

        if (healthSlider != null && health.MaxHealth != 0)
        {
            float targetValue = (float)health.CurrentHealth / health.MaxHealth;
            float animationDuration = 0.5f;
            healthSlider.DOValue(targetValue, animationDuration);
            
        }
    }

    public void OnDamageButtonClick(int amount)
    {
        health?.DecreaseHealth(amount);
        OnDamage?.Invoke();
    }

    public void OnHealButtonClick(int amount)
    {
        health?.IncreaseHealth(amount);
        OnHeal?.Invoke();
    }
    private void OnDestroy()
    {
        health.OnHealthChanged -= Health_OnHealthChanged;
    }
}