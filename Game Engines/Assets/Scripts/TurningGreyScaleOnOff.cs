using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningGreyScaleOnOff : MonoBehaviour
{
     public grey ascript;
      public bool greyed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
         if (greyed)
            {
                ascript.enabled = false;
            }
            else
            {
                 ascript.enabled = true;
            }
    }
}
