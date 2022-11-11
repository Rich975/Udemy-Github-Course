using UnityEngine;

public class RandomTorque : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed;
    [SerializeField] private float min, max;

    // Start is called before the first frame update
    private void Start()
    {
        rb=GetComponent<Rigidbody>();   
        speed = Random.Range(700, 1000);

        rb.AddForce(Vector3.up * speed * Time.deltaTime, ForceMode.Impulse);
        rb.AddTorque(new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max)));
    }

    // Update is called once per frame
    private void Update()
    {
    }
}