using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    //EnemyExplode EnemyExplode;
   // public float health = 3f;
   // bool Death = true;
   // public GameObject thisEnemy;
    //public bool dead = true;
    public float maxHealth = 100f;
    public static float health;
    public Image HealthBar;


    public void Start()
    {
        HealthBar = GetComponent<Image>();
        health = maxHealth;
    }
   public void Update()
    {


        //if (health <= 0 && dead == true)
        //{
            HealthBar.fillAmount = health / maxHealth;
            //if (health <= 0)
            //{
                //Die();
               // Death = false;

            //}
        //}
        
    }

   // public void TakeDamage2(int damage)
   // {
       // health -= damage;
       // dead = true;


       // Debug.Log("damage Taken");
    //}

    //void Die()
   // {
        
       // three_point_wavespawner.Enemiesalive--;
       // Destroy(gameObject);
        //dead = false;

   // }

    


    
}
