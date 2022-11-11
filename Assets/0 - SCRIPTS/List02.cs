using System.Collections.Generic;
using UnityEngine;

public class List02 : MonoBehaviour
{
    public GameObject[] gameObjects;
    public List<GameObject> list;

    public float min = -20f;
    public float max = 20f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InstantiateObjectsAndClearList();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddGameObjectsToList();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            GetObjectsWithTag("cylinder");
        }
    }

    private void GetObjectsWithTag(string tag)
    {
        string tagname = tag;
        foreach (GameObject go in list)
        {
            go.CompareTag(tagname);
            if (go.tag != tagname)
            {
                Debug.Log($"This {go.name} is not a sphere");

                list.Remove(go);
            }
        }
    }

    private void InstantiateObjectsAndClearList()
    {
        foreach (GameObject go in list)
        {
            float xPos = Random.Range(min, max);
            float zPos = Random.Range(min, max);
            go.transform.position = new Vector3(xPos, 0, zPos);

            if (go.GetComponent<Rigidbody>() == null)
            {
                go.AddComponent<Rigidbody>();
            }
            Rigidbody goRb = go.GetComponent<Rigidbody>();
            goRb.useGravity = false;

            goRb.AddTorque(xPos, zPos, zPos);

            Instantiate(go, go.transform.position, Quaternion.identity);
        }

        list.Clear();
    }

    private void AddGameObjectsToList()
    {
        int randomIndex = Random.Range(0, gameObjects.Length);
        GameObject gameObject = gameObjects[randomIndex];
        Debug.Log($"You have chose a {gameObject.name} to add to your list");

        list.Add(gameObject);
        Debug.Log(list.Count);
    }
}