using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSuns : MonoBehaviour
{
    public Vector3 positionMove;
    public Vector3 backPositionMove;
   // private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
       // originalPosition = transform.position;
        StartCoroutine(PositionLerp(positionMove, 40));
    }

    IEnumerator PositionLerp(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 originalPosition = transform.position;

         while(time < duration)
         {
             transform.position = Vector3.Lerp(originalPosition, targetPosition, time/ duration);
             time += Time.deltaTime;
             yield return null;
         }
         transform.position = targetPosition;
        if(transform.position == targetPosition){
             StartCoroutine(BackPositionLerp(backPositionMove, 40));
        }
         
    }

    IEnumerator BackPositionLerp(Vector3 target, float duration)
    {
        float time = 0;
       Vector3 BackToOriginalPosition = transform.position;
         if (transform.position == positionMove)
        {
             while(time < duration)
             {
                transform.position = Vector3.Lerp(BackToOriginalPosition, target, time/ duration);
                time += Time.deltaTime;
                yield return null;
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
