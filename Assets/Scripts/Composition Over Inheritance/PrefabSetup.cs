using UnityEngine;

public class PrefabSetup : MonoBehaviour
{
    public GameObject swordPrefab;
    public GameObject bowPrefab;
    public AudioClip swordSound;
    public AudioClip bowSound;

    void Start()
    {
        // Sword Prefab Setup
        GameObject sword = Instantiate(swordPrefab);
        var swordDamageDealer = sword.AddComponent<DamageDealer>();
        swordDamageDealer.damageAmount = 15;
        var swordSoundEmitter = sword.AddComponent<SoundEmitter>();
        swordSoundEmitter.attackSound = swordSound;
        sword.AddComponent<WeaponBase>();

        // Bow Prefab Setup
        GameObject bow = Instantiate(bowPrefab);
        var bowDamageDealer = bow.AddComponent<DamageDealer>();
        bowDamageDealer.damageAmount = 10;
        var bowSoundEmitter = bow.AddComponent<SoundEmitter>();
        bowSoundEmitter.attackSound = bowSound;
        bow.AddComponent<WeaponBase>();
    }
  
}