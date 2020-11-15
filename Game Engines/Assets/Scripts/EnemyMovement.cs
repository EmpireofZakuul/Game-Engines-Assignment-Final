using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [Header("Enemy Movement")]
    public float lookRadius = 20f;
    public NavMeshAgent nav;
    Transform target;
    private GameObject player;

    [Header("Enemy Speed")]
    public float originalSpeed = 5;
    public static float maxSpeed;
    public float speed = 20;

    public Vector3 baseLocation;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = PlayerManager.instance.player.transform;
        nav.GetComponent<NavMeshAgent>();
        originalSpeed = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance >= lookRadius)
        {
            nav.SetDestination(baseLocation);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

        
    }
}
