using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    //public Rigidbody projectile;
    public GameObject projectile;
    public Transform bulletSpawn;
    public float speed = 20;
   // public AudioSource source;
   // public AudioClip shot;


    public void Start()
    {
        //source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            Shoot();
        }

    }
    public void Shoot()
    {
        //source.Play();
        //Rigidbody instantiatedProjectile = Instantiate(projectile, this.transform.position, transform.rotation) as Rigidbody;
        //instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        GameObject bullet = Instantiate(projectile);
        bullet.transform.position = bulletSpawn.position;
        Quaternion rotation = transform.rotation;
        // Vector3 rotation = bullet.transform.rotation.eulerAngles;
        // bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.right * speed, ForceMode.Impulse);

    }
}
