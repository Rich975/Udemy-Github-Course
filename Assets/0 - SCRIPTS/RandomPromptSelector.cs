using UnityEngine;

public class RandomPromptSelector : MonoBehaviour
{
    [SerializeField] int min, max;
    private int result;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomPromptGenerator(1, 151);
        }
    }

    private void RandomPromptGenerator(int min, int max)
    {
        result = Random.Range(min, max);
        Debug.Log(result);
    }
}