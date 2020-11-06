using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject spawnTile;
    public GameObject currentTile;


    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(spawnTile, currentTile.transform.GetChild(0).transform.GetChild(2).position, Quaternion.identity);
    }
}
