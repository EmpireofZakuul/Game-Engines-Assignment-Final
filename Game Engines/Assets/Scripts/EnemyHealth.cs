using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public GameObject theObjectToBeUnParented;


    public void Update()
    {
        if(theObjectToBeUnParented = null)
        {
            Destroy(this.gameObject, 1f);
        }
    }


}
