using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcScript : MonoBehaviour
{


    public Transform target;    // Hedef pozisyonu
    private NavMeshAgent agent; // NavMeshAgent bileþeni

    void Start()
    {
        // NavMeshAgent bileþenini al
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Hedef pozisyonunu NavMeshAgent'e ayarla
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }


}
