using System;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    [SerializeField] private HealthPresenter healthPresenter;
    [SerializeField] private GameObject damageParticles;
    [SerializeField] private GameObject healParticles;

    private void Start()
    {
        healthPresenter.OnDamage += HealthPresenter_OnDamage;
        healthPresenter.OnHeal += HealthPresenter_OnHeal;
        
    }

    private void HealthPresenter_OnDamage()
    {
        var damageParticleInstance = Instantiate(damageParticles, damageParticles.transform.position, Quaternion.identity);
        Destroy(damageParticleInstance, 0.5f);
    }

    private void HealthPresenter_OnHeal()
    {
        var healParticleInstance = Instantiate(healParticles, healParticles.transform.position, Quaternion.identity);
        Destroy(healParticleInstance, 0.5f);
    }

    private void OnDestroy()
    {
        healthPresenter.OnDamage -= HealthPresenter_OnDamage;
        healthPresenter.OnHeal -= HealthPresenter_OnHeal;
    }
}