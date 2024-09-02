using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public GameObject Player;
    private string state = "Stand";
    private Vector3 startPosition;
    public int health = 100;
    public int damage = 10;
    private Animator animator;
    public float AttackDistance = 1;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();

        startPosition = transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (state == "Stand")
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
        else if (state == "Death") 
        {
            Death();
        }

        animator.SetFloat("Speed", agent.velocity.sqrMagnitude);
    }

    private void Stand()
    {

    }

    private void Chase()
    {
        float ditance = Vector3.Distance(transform.position, Player.transform.position); ;
        if(ditance < AttackDistance)
        {
            state = "Attack";
        }
        else
        {
            agent.SetDestination(Player.transform.position);
        }
    }

    private void Attack()
    {
        float ditance = Vector3.Distance(transform.position, Player.transform.position); ;
        if (ditance < AttackDistance)
        {
            print("Атакую");
            animator.SetBool("Attack", true);
        }
        else
        {
            state = "Chase";
            animator.SetBool("Attack", false);
        }
    }

    private void Goback()
    {
        agent.SetDestination(startPosition);
    }

    private void Death()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (state == "Death") return;
            state = "Chase";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (state == "Death") return;
            state = "Goback";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health = health - damage;
            Destroy(collision.gameObject);
            if(health < 0)
            {
                state = "Death";
                animator.SetTrigger("Death");
                Destroy(gameObject, 10);
                GetComponent<CapsuleCollider>().enabled = false;
            }
        }
    }

    private void GivePlayerDamage()
    {
        Health playerHealth = Player.GetComponent<Health>();
        playerHealth.TakeDamage(20);
    }
}
