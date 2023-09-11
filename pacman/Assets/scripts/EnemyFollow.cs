using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent zombies;
    public Transform leon;

    public powerScript power;
    
    // Start is called before the first frame update
    void Start()
    {
        power = FindObjectOfType<powerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        zombies.SetDestination(leon.position);
        if (power.powerUp == true)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            Invoke("zombieStart", 1f);

        }
    }

    void zombieStart()
    {
        gameObject.GetComponent<NavMeshAgent>().isStopped = false;
    }
}
