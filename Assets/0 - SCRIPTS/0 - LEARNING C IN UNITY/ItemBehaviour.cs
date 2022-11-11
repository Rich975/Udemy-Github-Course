using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public GameBehaviour gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("Game_Manager").GetComponent<GameBehaviour>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PlayerFPController")
        {
            Destroy(this.transform.gameObject);
            gameManager.Items += 1;
            Debug.Log("item collected!");
        }
    }
}
