﻿using System.Collections;
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

    public bool[,] grid;


public void OnEnable()
{
    grid = new bool[gridXAxis, gridYAxis];
    SpawnGridCity();
}
  
   public void SpawnGridCity()
    {
        
        for (int x = 0; x < gridXAxis; x++)
        {
            for (int z = 0; z < gridYAxis; z++)
            {
                if(grid[x,z]) continue;
                grid[x,z] = true;
                GameObject Prefabclone = Instantiate(_prefabSpawnBuilding,
                    transform.position + centerOfTheGrid + new Vector3(individualBuildingSpacing * x, 0, individualBuildingSpacing * z), transform.rotation);
                Prefabclone.transform.SetParent(this.transform);
            }
        }
    }

   // public void Roads()//change out prefab for roads
    //{
      //  for (int x = 0; x < gridXAxis; x++)
       // {
          //  for (int z = 0; z < gridYAxis; z++)
           // {
               // if(grid[x,z]) continue;
               // !grid[x,z] = true;
               // GameObject Prefabclone = Instantiate(_prefabSpawnBuilding,
                 //   transform.position + centerOfTheGrid + new Vector3(individualBuildingSpacing * x, 0, individualBuildingSpacing * z), transform.rotation);
               // Prefabclone.transform.SetParent(this.transform);
           // }
       //}
   // }
    
}
