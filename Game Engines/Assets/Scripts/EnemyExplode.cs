using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplode : MonoBehaviour
{
   [Header("Enemy Explode")]
    public Transform effect;
         public bool explode = false;
    public AudioSource source;
    public AudioClip[] clipsAudio;
    //public GameObject theObjectToBeUnParented;
    public GameObject destroy;
    public bool dead = false;
    [Header("Enemy Health")]
    public int maxHealth = 100;
    public int health;
    public EnemyHealthBar EnemyHealthBar;

    //[SerializeField]  
     public Spawner Spawner;
     public float BlowRadius = 6f;
     public CharacterMovement character;


    // Start is called before the first frame update
    void OnEnable()
    {

        health = maxHealth;
        EnemyHealthBar.setMaxHealth(maxHealth);

        //enemyHealth = GetComponentInParent<EnemyHealth>();
        source = GetComponent<AudioSource>();
        
       // source.clip = clipsAudio[0];
        //source.Play();
        GameObject.Find("Spawner").GetComponents<Spawner>();
        Spawner = FindObjectOfType<Spawner>();
        Spawner.isFound = true;

       // GameObject.Find("character").GetComponents<CharacterMovement>();
       //character = FindObjectOfType<CharacterMovement>();
        //character.isFound = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <=0 && !explode)
        {

            StartCoroutine(ExampleCoroutine());
            explode = true;
            Spawner.count--;
           //Spawner.GetComponents<Spawner>()
            //GameObject.Find("Spawner").GetComponents<Spawner>();
            
        }
  
    }

    IEnumerator ExampleCoroutine()
    {
        //theObjectToBeUnParented.transform.SetParent(null);
        //Destroy(theObjectToBeUnParented, 1f);
        //yield return new WaitForSeconds(2);
        source.clip = clipsAudio[0];
        source.Play();
        yield return new WaitForSeconds(2);
        source.clip = clipsAudio[1];
        source.Play();
        Instantiate(effect, transform.position, transform.rotation);
        Explode();
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
      public void Explode()
    {

      
            Collider[] coll = Physics.OverlapSphere(transform.position, BlowRadius);

            for (int i = 0; i < coll.Length; i++)
            {
                if (coll[i].gameObject.GetComponent<CharacterMovement>())
                {
                    //coll[i].gameObject.GetComponent<PlayerHealth>().health -= damage;
                    character.TakeDamageCharacter(15);
                   // coll[i].gameObject.GetComponent<Rigidbody>().AddExplosionForce(expolsiveForce, transform.position, BlowRadius);
                }
            }
          
          
        
        
    }
}
