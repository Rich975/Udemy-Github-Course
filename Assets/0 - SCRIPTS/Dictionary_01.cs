using System.Collections.Generic;
using UnityEngine;

public class Dictionary_01 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Dictionary<string, int> goldAmount = new Dictionary<string, int>()
        {
            {"Richie", 36 },
            {"Tom", 23 },
            {"Martijn", 6000000 }
        };

        Debug.Log($"{goldAmount.Keys}");
        Debug.Log($"{goldAmount.Values}");

        goldAmount.Add("Doofus", 56);

        Debug.Log($"Doofus has: {goldAmount["Doofus"]} gold!");

        if (goldAmount.ContainsKey("Martijn"))
        {
            Debug.LogFormat("The Martijn key is included");

        } else
        {
            Debug.Log("This key is not included");
        }

        Debug.Log(goldAmount.Values);

        Debug.LogFormat("Items: {0}", goldAmount.Count);

        int richysGold = goldAmount["Richie"];
        Debug.Log(richysGold);

        goldAmount["Richie"] = 10;
        Debug.Log(goldAmount["Richie"]);

        foreach (KeyValuePair<string, int> kvp in goldAmount)
        {
            Debug.Log($"Key is: {kvp.Key} and its corresponding value is: {kvp.Value}");
            Debug.Log(kvp);
        }


    }

    // Update is called once per frame
    private void Update()
    {
    }
}