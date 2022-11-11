using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerFPController")
        {
            Debug.Log("Player detected - attack!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "PlayerFPController")
        {
            Debug.Log("Player out of detection range, resuming patrol");
        }
    }


}
