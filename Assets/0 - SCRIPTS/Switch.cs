using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject go;

    public new ParticleSystem particleSystem;

    public MeshRenderer meshRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        if (GetComponent<ParticleSystem>() != null)
        {
            particleSystem = GetComponent<ParticleSystem>();
            particleSystem.Stop();
        }

        meshRenderer = GetComponent<MeshRenderer>();
        go = this.gameObject;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void ObjectCheck()
    {
        switch (go.name)
        {
            case "object01":
                Debug.Log("You are touching object 01");
                break;

            case "object02":
                gameObject.SetActive(false);
                break;

            case "object03":
                Debug.Log("You are touching numba threeeee!!");
                break;

            case "object04":
                meshRenderer.material.color = Color.red;
                Debug.Log("I have turned red, like a commie");
                break;

            case "object05":
                particleSystem.Play();
                break;

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ObjectCheck();
        }
    }
}