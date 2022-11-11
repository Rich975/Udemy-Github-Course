using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float timeToDestroy = 2f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Destroy(this.gameObject, timeToDestroy);
    }
}