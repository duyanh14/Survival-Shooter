using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent enemy;
    public Transform player;
    
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
