using UnityEngine;

public class RandomColorizer : MonoBehaviour
{
    private MeshRenderer mr;
    [SerializeField] private Color[] colors;

    private int randomColorIndex;
    private Color color;

    private GameObject[] gameObjects;

    // Start is called before the first frame update
    private void Start()
    {
        gameObjects = GetComponent<List02>().gameObjects;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (GameObject g in gameObjects)
            {
                //MeshRenderer mr = new MeshRenderer();
                mr = g.GetComponent<MeshRenderer>();

                randomColorIndex = Random.Range(0, colors.Length);
                color = colors[randomColorIndex];
                mr.material.color = color;
            }

        }
    }
}