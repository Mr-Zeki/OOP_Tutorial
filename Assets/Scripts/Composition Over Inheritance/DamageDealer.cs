using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 10;

    public void DealDamage(GameObject target)
    {
        Debug.Log($"Dealing {damageAmount} damage to {target.name}");
        // Burada hedefin sa�l�k sistemine eri�erek hasar uygulayabilirsiniz.
    }
}