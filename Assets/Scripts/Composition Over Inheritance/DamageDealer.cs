using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 10;

    public void DealDamage(GameObject target)
    {
        Debug.Log($"Dealing {damageAmount} damage to {target.name}");
        // Burada hedefin saðlýk sistemine eriþerek hasar uygulayabilirsiniz.
    }
}