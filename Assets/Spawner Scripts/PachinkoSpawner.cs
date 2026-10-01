using UnityEngine;

public class PachinkoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pachinkoPrefab;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float spawnRange = 5f;

    void Start()
    {
        InvokeRepeating( nameof( SpawnPachinko ), 1f, spawnInterval );
    }
       
    private void SpawnPachinko()
    {
        Vector3 randomPos = new Vector3( Random.Range(-spawnRange, spawnRange), 45, 0 );

        Instantiate( pachinkoPrefab, randomPos, Quaternion.identity );
    }
}
