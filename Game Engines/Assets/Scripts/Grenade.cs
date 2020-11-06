using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float radiusExplosion = 16f;
    public float forceOfExplosion = 20f;
    public float delay = 3f;
    private float countdown;
    bool grenadeExploded = false;
    public static int BulletDamage;
    public int damage = 1;
    public Transform explosionEffect;
    public Transform explosionEffect2;
    public AudioSource source;
    public AudioClip shot;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && !grenadeExploded)
        {
            Explode();
            grenadeExploded = true;


        }


    }

    public void Explode()
    {
        source.Play();
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Instantiate(explosionEffect2, transform.position, transform.rotation);
        //Collider[] coll = Physics.OverlapSphere(transform.position, radiusExplosion);

        //  for (int i = 0; i < coll.Length; i++)
        // {
        // if (coll[i].gameObject.GetComponent<EnemyHealth>())
        // {
        // coll[i].gameObject.GetComponent<EnemyHealth>().TakeDamage2(damage);
        //coll[i].gameObject.GetComponent<Rigidbody>().AddExplosionForce(forceOfExplosion, transform.position, radiusExplosion);
        // }
        // }

        Debug.Log("boom");
        Destroy(gameObject, 1f);
    }
}
