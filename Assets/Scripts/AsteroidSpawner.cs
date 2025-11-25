using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnInterval = 1.5f;
    public float spawnDistance = 0.5f;
    public float minSpeed = 1f;
    public float maxSpeed = 4f;
    public float maxTorque = 50f;

    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating(nameof(SpawnAsteroid), 1f, spawnInterval);
    }

    void SpawnAsteroid()
    {
        if (player == null) return;

        Vector2 dir = Random.insideUnitCircle.normalized;
        Vector3 pos = player.position + (Vector3)dir * spawnDistance;

        GameObject a = Instantiate(asteroidPrefab, pos, Quaternion.identity);
        Rigidbody2D rb = a.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 target = (player.position - a.transform.position).normalized;
            rb.linearVelocity = target * Random.Range(minSpeed, maxSpeed);
            rb.AddTorque(Random.Range(-maxTorque, maxTorque));
        }
    }
}
