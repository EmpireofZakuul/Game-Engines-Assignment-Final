using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDie : MonoBehaviour
{
   

    private void Start()
    {
        

    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            
            
                other.gameObject.GetComponent<EnemyHealth>();
                EnemyHealth.health -= 3f;
                Destroy(gameObject, 1f);
                Debug.Log("Hit! " + other.name);
            
                //other.gameObject.GetComponent<EnemyHealth>();
           // EnemyHealth.health -= 3f;
            //Destroy(gameObject, 1f);
           // Debug.Log("Hit! " + other.name);
        }
        

    }
     
     
}
