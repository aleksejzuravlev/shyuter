using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public GameObject Player;
    private string state = "Chase";

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(state == "Stand")
        {
            Stand();
        }
        else if (state == "Chase")
        {
            Chase();
        }
        else if (state == "Attack")
        {
            Attack();
        }
        else if (state == "Goback")
        {
            Goback();
        }
    }

    private void Stand()
    {

    }

    private void Chase()
    {
        agent.SetDestination(Player.transform.position);
    }

    private void Attack()
    {

    }

    private void Goback()
    {

    }
}
