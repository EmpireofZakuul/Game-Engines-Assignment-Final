using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingControl : MonoBehaviour
{
    public static BuildingControl instance;
    public List<GameObject> generate = new List<GameObject>();
    public CreatePerlinNoise perlinNoiseGenerater;
    public Grid gridSpawn;

     
    // Start is called before the first frame update

public void Awake()
{
      if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
}
    void Start()
    {
        ManagerGenerate();
    }

    public void ManagerGenerate()
    {
        perlinNoiseGenerater.Generate();
        gridSpawn.GeneratePlay();
    }

    public void Objects(GameObject ObjectsAdd)
    {
        generate.Add(ObjectsAdd);
    }

}
