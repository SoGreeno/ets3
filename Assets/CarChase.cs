using UnityEngine;
using UnityEngine.AI;

public class CarChase : MonoBehaviour
{
    public float chaseDistance = 10f;
    public float speed = 3f;
    private NavMeshAgent agent;
    private Transform player;

    void Start()
    {
        // Get the NavMeshAgent component
        agent = GetComponent<NavMeshAgent>();
        // Find the player GameObject by its tag
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        // Calculate the distance between the car and the player
        float distance = Vector3.Distance(transform.position, player.position);
        // If the player is within the chase distance
        if (distance <= chaseDistance)
        {
            // Set the car's destination to the player's position
            agent.SetDestination(player.position);
            // Adjust the car's speed
            agent.speed = speed;
        }
    }
}