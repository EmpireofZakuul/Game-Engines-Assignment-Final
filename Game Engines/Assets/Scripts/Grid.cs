using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int gridXAxis = 4;
    public int gridYAxis = 4;
    public GameObject _prefabSpawnBuilding;
    public Vector3 centerOfTheGrid = Vector3.zero;

    public float individualBuildingSpacing = 2f;
    public bool onEnableGenerate;
    public GameObject NavMeshSurface;


    void OnEnable()
    {
        if (onEnableGenerate)
        {
            GeneratePlay();

        }
    }
    void SpawnGridCity()
    {
        for (int x = 0; x < gridXAxis; x++)
        {
            for (int z = 0; z < gridYAxis; z++)
            {
                GameObject Prefabclone = Instantiate(_prefabSpawnBuilding,
                    transform.position + centerOfTheGrid + new Vector3(individualBuildingSpacing * x, 0, individualBuildingSpacing * z), transform.rotation);
                Prefabclone.transform.SetParent(this.transform);
            }
        }


    }
    public void GeneratePlay()
    {
        SpawnGridCity();

    }


}
