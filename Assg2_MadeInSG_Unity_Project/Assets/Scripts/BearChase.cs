using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BearChase : MonoBehaviour
{
    //Navmesh variables
    public NavMeshAgent agent;
    public GameObject toEnable;
    public Transform player;

    //make sure bear does not go over 100000 (player will probably lose when the bear hits a speed of 50)
    float speedcap = 100000f;

    public void Start()
    {
        //start the coroutine of the function every 1 second
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine("IncreaseSpeedPerSecond", 1f);
    }

    public void Update()
    {
        //update every frame to chase the player's position
        agent.SetDestination(player.position);
    }

    IEnumerator IncreaseSpeedPerSecond (float waitTime)
    {
        while (agent.speed < speedcap)
        {
            //increase speed by 0.3 every second
            yield return new WaitForSeconds(waitTime);
            agent.speed = agent.speed + 0.3f;
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //when the bear reaches the player, game ends
            toEnable.SetActive(true);
            Debug.Log("Lose");
        }
    }
}
