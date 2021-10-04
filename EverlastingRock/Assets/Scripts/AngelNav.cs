using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AngelNav : MonoBehaviour
{
    public Transform player;
    private Vector3 playerPos;
    

    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.transform.position;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = playerPos;
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 newPlayerPos = player.transform.position;
        if (newPlayerPos != playerPos)
        {
            playerPos = newPlayerPos;
        }
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = playerPos;
    }

    //void FixedUpdate()
    //{
    //    playerPos = player.transform.position;
    //    NavMeshAgent agent = GetComponent<NavMeshAgent>();
    //    agent.destination = playerPos;
    //}
}
