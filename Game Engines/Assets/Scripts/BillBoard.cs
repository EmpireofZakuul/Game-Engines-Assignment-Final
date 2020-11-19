using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    private Transform playerCam;
    // Start is called before the first frame update
    void Start()
    {
      GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

       
    }

public void OnEnable()
    {
    playerCam = Camera.main.transform;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + playerCam.forward);
        
    }
}
