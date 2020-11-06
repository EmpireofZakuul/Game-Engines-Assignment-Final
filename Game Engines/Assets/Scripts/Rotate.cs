using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float time = 2f;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(time * Time.deltaTime, 0, 0);
        // Spin the object around the target at 20 degrees/second.
        transform.Rotate(direction, 20 * Time.deltaTime);
    }
    
}
