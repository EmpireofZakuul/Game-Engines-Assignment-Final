using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingControl : MonoBehaviour
{
    public static BuildingControl instance;
    public List<GameObject> generate = new List<GameObject>();
    public CreatePerlinNoise perlinNoise;
    public Grid gridSpawn;

     
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
 
    ManagerGenerate();
    }

    public void ManagerGenerate()
    {
        perlinNoise.Generate();
        gridSpawn.GeneratePlay();
    }

    public void Objects(GameObject ObjectsAdd)
    {
        generate.Add(ObjectsAdd);
    }

}
