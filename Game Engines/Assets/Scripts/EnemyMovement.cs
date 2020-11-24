﻿using System.Collections;
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
    //public GameObject enemeyColour;
      public float intensity;

      public GameObject enemeyColour;

    public Vector3 baseLocation;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = PlayerManager.instance.player.transform;
        nav.GetComponent<NavMeshAgent>();
        originalSpeed = maxSpeed;

       Renderer r = enemeyColour.GetComponent<Renderer>();
        //r.material.SetColor("_EmissionColor", Color.HSVToRGB(1f, 1f, 1f) * intensity);
        r.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance >= lookRadius)
        {
           // nav.SetDestination(baseLocation);
            nav.SetDestination(target.transform.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

        
    }
}
