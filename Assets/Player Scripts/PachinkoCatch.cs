using UnityEngine;

public class PachinkoCatch : MonoBehaviour
{
    [SerializeField] private int coinValue = 1;
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
