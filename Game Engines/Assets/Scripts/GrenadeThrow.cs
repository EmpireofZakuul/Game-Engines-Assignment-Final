using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GrenadeThrow : MonoBehaviour
{
    
    public float fireRate = 15f;
   
    private float nextTimeToFire = 0f;
    public GameObject grenade;
    public float speed = 20;
    public Transform Hand;
    public int Grenadeamound = 5;
    public TextMeshProUGUI grenades;



    public void Start()
    {
     
      
        
    }
    // Start is called before the first frame update
    void Update()
    {
        // grenades.text = Grenadeamound.ToString();
        grenades.SetText(Grenadeamound.ToString());
        if (Grenadeamound > 0)
        {



            if (Input.GetButton("Fire2") && Time.time >= nextTimeToFire)
            //if (Input.GetKeyDown(KeyCode.F) && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }

    }
    public void Shoot()
    {
        Grenadeamound--;

        // Rigidbody instantiatedProjectile = Instantiate(Grenade, transform.position, transform.rotation) as Rigidbody;
        // instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        GameObject gren = Instantiate(grenade, Hand.position, Hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(Hand.forward * speed, ForceMode.Impulse);
    }
}
