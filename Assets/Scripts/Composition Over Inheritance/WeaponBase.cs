using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    private DamageDealer damageDealer;
    private SoundEmitter soundEmitter;

    void Awake()
    {
        damageDealer = GetComponent<DamageDealer>();
        soundEmitter = GetComponent<SoundEmitter>();
    }

    public void Attack(GameObject target)
    {
        damageDealer?.DealDamage(target);
        soundEmitter?.PlaySound();
        Debug.Log($"{gameObject.name} attacked {target.name}");
    }
}
