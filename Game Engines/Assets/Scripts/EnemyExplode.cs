using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplode : MonoBehaviour
{
   [Header("Enemy Explode")]
    public Transform effect;
   public Spawner Spawner;
    public bool explode = false;
    public AudioSource source;
    public AudioClip[] clipsAudio;
    public GameObject theObjectToBeUnParented;
    public GameObject destroy;
    public bool dead = false;
    [Header("Enemy Health")]
    public int maxHealth = 100;
    public int health;
    public EnemyHealthBar EnemyHealthBar;

    // Start is called before the first frame update
    void OnEnable()
    {

        health = maxHealth;
        EnemyHealthBar.setMaxHealth(maxHealth);

        //enemyHealth = GetComponentInParent<EnemyHealth>();
        source = GetComponent<AudioSource>();
        
       // source.clip = clipsAudio[0];
        //source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <=0 && !explode)
        {

            StartCoroutine(ExampleCoroutine());
            explode = true;
            Spawner.count--;
        }
    }

    IEnumerator ExampleCoroutine()
    {
        theObjectToBeUnParented.transform.SetParent(null);
        Destroy(theObjectToBeUnParented, 1f);
        yield return new WaitForSeconds(2);
        source.clip = clipsAudio[0];
        source.Play();
        yield return new WaitForSeconds(2);
        source.clip = clipsAudio[1];
        source.Play();
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(destroy, 0.9f);

       

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bull")
        {
            TakeDamage(20);
        }
        
    }

    public void TakeDamage(int damage)
    {

        health -= damage;
        EnemyHealthBar.SetHealth(health);

    }
}
