using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isPickup;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && isPickup)
        {
            Debug.Log("You may pick me up");
        }
        else
            Debug.Log("Im not a pickup");
    }
}