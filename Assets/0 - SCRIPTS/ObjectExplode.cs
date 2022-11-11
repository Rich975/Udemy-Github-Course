using UnityEngine;

public class ObjectExplode : MonoBehaviour
{
    ParticleSystem particleSystem;
    float timeToExplode = 2f;

    // Start is called before the first frame update
    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    private void Update()
    {
        TimeToZero();
        //Destroy(gameObject, 1f);    

    }

    private void TimeToZero()
    {
        timeToExplode -= Time.deltaTime;
        if(timeToExplode <= 0)
        {
            ExplosionSpawn(particleSystem);
            Destroy(gameObject);
        }
            timeToExplode = 2;

    }

    private void ExplosionSpawn(ParticleSystem ps)
    {
        ps = particleSystem;
        Instantiate(ps, transform.position, Quaternion.identity);
    }
    
}
