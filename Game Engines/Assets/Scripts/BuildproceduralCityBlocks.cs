﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildproceduralCityBlocks : MonoBehaviour
{
  
    public int maxPiecesOfBuilding = 20;
    public float perlinScale = 2f;

    public int minimumRandom = 0;
    public int maximumRandom = 5;
    public GameObject[] buildingBaseParts;
    public GameObject[] buildingMiddleParts;
    public GameObject[] buildingTopParts;

    public bool spotTaken = false;

    void Start()
    {
        CityBuild();
    }

    

    public void CityBuild()
    {
        //sample the perlin noise
        float sampledValue = CreatePerlinNoise.instance.PerlinImage(transform.position);

         int Pieces = Mathf.FloorToInt(maxPiecesOfBuilding * (sampledValue));
        Pieces += Random.Range(minimumRandom, maximumRandom);

        if (Pieces <= 0)
        {
            return;
        }

        float heightBuildings = 0;
        heightBuildings += SpawnLayout(buildingBaseParts, heightBuildings);

        for (int i = 2; i < Pieces; i++)
        {
            heightBuildings += SpawnLayout(buildingMiddleParts, heightBuildings);
        }

        SpawnLayout(buildingTopParts, heightBuildings);
    }

    float SpawnLayout(GameObject[] ArrayPieces, float inputHeight)
    {
        Transform randomTransform = ArrayPieces[Random.Range(0, ArrayPieces.Length)].transform;
        GameObject cloneSpawn = Instantiate(randomTransform.gameObject, this.transform.position + new Vector3(0, inputHeight, 0), transform.rotation) as GameObject;
        Mesh cloneMesh = cloneSpawn.GetComponentInChildren<MeshFilter>().mesh;
        Bounds baseBounds = cloneMesh.bounds;
        float OffsetHeight = baseBounds.size.y;

        cloneSpawn.transform.SetParent(this.transform);
    
        BuildingControl.instance.Objects(cloneSpawn);

        return OffsetHeight;
    }
    
}
