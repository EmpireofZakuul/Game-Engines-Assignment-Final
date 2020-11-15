using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDie : MonoBehaviour
{
   

    private void Start()
    {
        

        Destroy(this.gameObject, 2f);
    }
    

    public void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Enemy")
        //{

         
            //other.gameObject.GetComponent<EnemyHealth>();
               //// EnemyHealth.health -= 3f;
                //Destroy(this.gameObject, 0.5f);
               // Debug.Log("Hit! " + other.name);
            
                //other.gameObject.GetComponent<EnemyHealth>();
           // EnemyHealth.health -= 3f;
            //Destroy(gameObject, 1f);
           // Debug.Log("Hit! " + other.name);
       // }
        
        
            
        
        

    }
  


    //public void OnTriggerEnter()
    //{
       // EnemyHealth.TakeDamage2(20); 

   // }

}
