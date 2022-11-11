using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject largeAsteroid;
    public GameObject mediumAsteroid;
    public GameObject smallAsteroid;

    public Transform spawnPos;
    public Transform spawnPos02;
    public Transform[] spawnPositions;

    public int numberToSpawn;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnAsteroids(largeAsteroid, 99, 3);
            SpawnAsteroids(mediumAsteroid, 50, 3);
            SpawnAsteroids(largeAsteroid, 25, 3);
        }
    }

    public void SpawnAsteroids(GameObject asteroidToSpawn, int damage, int amount)
    {
        Asteroid asteroid = new Asteroid(largeAsteroid, mediumAsteroid, smallAsteroid, 69);
        numberToSpawn = amount;
        GameObject tempAsteroid = asteroidToSpawn;
        asteroid.damage = damage;

        for (int i = 0; i < numberToSpawn; i++)
        {
            int randomIndex = Random.Range(0, spawnPositions.Length);
            Instantiate(tempAsteroid, spawnPositions[randomIndex].position,
                                        spawnPositions[randomIndex].rotation);
            asteroid.CheckDamage();
        }
    }
}