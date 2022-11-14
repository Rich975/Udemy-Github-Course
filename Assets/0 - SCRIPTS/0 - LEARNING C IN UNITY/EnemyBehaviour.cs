using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform patrolRoute;
    public List<Transform> locations;

    private int _locationIndex = 0;
    private NavMeshAgent _meshAgent;

    public Transform player;

    private void Start()
    {
        player = GameObject.Find("PlayerFPController").GetComponent<Transform>();
        _meshAgent = GetComponent<NavMeshAgent>();
        InitializePatrolRoute();
        MoveToNextPatrolLocation();
    }

    private void Update()
    {
        if (_meshAgent.remainingDistance < 0.2f && !_meshAgent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
    }


    private void MoveToNextPatrolLocation()
    {
        if(locations.Count == 0)
        {
            return;
        }
        _meshAgent.destination = locations[_locationIndex].position;
        _locationIndex = (_locationIndex + 1) % locations.Count;

    }

    private void InitializePatrolRoute()
    {
        foreach (Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerFPController")
        {
            _meshAgent.destination = player.position;
            Debug.Log("Enemy detected");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerFPController")
        {
            Debug.Log("Player out of detection range, resuming patrol");
        }
    }
}