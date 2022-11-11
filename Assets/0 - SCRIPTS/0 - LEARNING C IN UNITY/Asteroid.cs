using UnityEngine;

public class Asteroid
{
    public GameObject largeAsteroid;
    public GameObject mediumAsteroid;
    public GameObject smallAsteroid;

    public int damage;

    public Asteroid(GameObject largeAsteroid, GameObject mediumAsteroid, GameObject smallAsteroid, int damage)
    {
        this.largeAsteroid = largeAsteroid;
        this.mediumAsteroid = mediumAsteroid;
        this.smallAsteroid = smallAsteroid;

        this.damage = damage;
    }

    public void CheckDamage()
    {
        Debug.Log($"Damage: {this.damage}");
    }
}