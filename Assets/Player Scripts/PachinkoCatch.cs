using UnityEngine;

public class PachinkoCatch : MonoBehaviour
{
    [SerializeField] private int coinValue = 1;
    [SerializeField] private AudioClip pickupSoundClip;

    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = Object.FindFirstObjectByType<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddToScore();
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(pickupSoundClip, transform.position, 1f);
        }
        else if (other.CompareTag("Base"))
        {
            Destroy(gameObject);
        }
    }
    
    private void AddToScore()
    {
        scoreManager.AddScore();
        Debug.Log("Player collected coin worth: " + coinValue);
    }
}
