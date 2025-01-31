using UnityEngine;

public class AuidoManager : MonoBehaviour
{
    [SerializeField] private AudioClip coinCollect;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        PlayerInteractions.OnCoinCollected += PlayerInteractions_OnCoinCollected;
    }

    private void PlayerInteractions_OnCoinCollected()
    { 
        _audioSource.clip = coinCollect;
        if (_audioSource != null)
        {
            _audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is missing, I can't play audio");
        }
    }

    private void OnDisable()
    {
        PlayerInteractions.OnCoinCollected -= PlayerInteractions_OnCoinCollected;
    }
}