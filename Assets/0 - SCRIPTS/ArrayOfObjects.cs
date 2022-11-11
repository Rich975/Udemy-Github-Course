using UnityEngine;

public class ArrayOfObjects : MonoBehaviour
{
    public GameObject[] objects;
    public Transform[] objectsTransform;
    public int randomTransformIndex;
    public int tempRandom;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LaunchRandomObjectFromRandomTransform();
        }
    }

    public Vector3 LaunchRandomObjectFromRandomTransform()
    {
        int randomIndex = Random.Range(0, objects.Length);
        randomTransformIndex = Random.Range(0, objectsTransform.Length);

        Instantiate(objects[randomIndex], objectsTransform[randomTransformIndex]);
        Vector3 transformPos = objects[randomTransformIndex].gameObject.transform.position;

        return transformPos;
    }
}