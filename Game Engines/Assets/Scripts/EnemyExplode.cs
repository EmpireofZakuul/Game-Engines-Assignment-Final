using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplode : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public Transform effect;
    Spawner Spawner;
    public bool explode = false;
    public AudioSource source;
    public AudioClip[] clipsAudio;
    public GameObject theObjectToBeUnParented;
    // Start is called before the first frame update
    void OnEnable()
    {
        enemyHealth = GetComponentInParent<EnemyHealth>();
        source = GetComponent<AudioSource>();
        
        source.clip = clipsAudio[0];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth.health <= 0 && !explode)
        {

            StartCoroutine(ExampleCoroutine());
            explode = true;
            Spawner.count--;
        }
    }

    IEnumerator ExampleCoroutine()
    {
        theObjectToBeUnParented.transform.SetParent(null);
        yield return new WaitForSeconds(2);
        source.clip = clipsAudio[1];
        source.Play();
        yield return new WaitForSeconds(2);
        source.clip = clipsAudio[2];
        source.Play();
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject, 0.9f);

       

    }
}
