using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePerlinNoise : MonoBehaviour
{
    [Header("Perlin Noise Image Size")]
    public int perlinImageWidth = 256;
    public int perlinImageHeight = 256;
    public static CreatePerlinNoise instance = null;
    [Header("Perlin Noise ")]
    public Vector2 offsetOfThePerlinNoiseTexture;
    public bool randomizeTexture;
    public float scaleOfTheNoise = 1f;
    public int perlinNoiseXAxisGrid = 4;
    public int perlinNoiseYAxisGrid = 4;
    public float perlinHeight = 4f;

    private Texture2D texture;
    public GameObject Building;
    public RawImage vis;
    public bool gridVisual = false;
   public void Start()
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

    public void Generate()
    {
        GeneratePerlinTexture();
        if(gridVisual)
        {
            GridSpawn();
        }

    }

    public void Update()
    {
        //Renderer renderer = GetComponent<Renderer>();
        //renderer.material.mainTexture = GeneratePerlinTexture();
    }

    public  void GeneratePerlinTexture()
    {
        if (randomizeTexture)
        {
            offsetOfThePerlinNoiseTexture = new Vector2(Random.Range(0, 99999), Random.Range(0, 99999));
        }

         texture = new Texture2D(perlinImageWidth, perlinImageHeight);

        for (int x = 0; x < perlinImageWidth; x++)
        {
            for (int y = 0; y < perlinImageHeight; y++)
            {
                texture.SetPixel(x, y, Noise(x, y));
            }
        }

        texture.Apply();

        vis.texture = texture;
    }

    Color Noise(int x, int y)
    {
        float XCoordinate = (float)x / perlinImageWidth * scaleOfTheNoise + offsetOfThePerlinNoiseTexture.x;
        float YCoordinate = (float)y / perlinImageHeight * scaleOfTheNoise + offsetOfThePerlinNoiseTexture.y;

        float sampled = Mathf.PerlinNoise(XCoordinate, YCoordinate);
        Color ColorOfThePerlin = new Color(sampled, sampled, sampled);

        return ColorOfThePerlin;
    }

    public float CreateNoise(int x, int y)
    {
        int gridStepSizeX = perlinImageHeight / perlinNoiseXAxisGrid;
        int gridStepSizeY = perlinImageWidth / perlinNoiseYAxisGrid;

        float sampledFloat = texture.GetPixel
        ((Mathf.FloorToInt(x * gridStepSizeX)), (Mathf.FloorToInt(y * gridStepSizeX))).grayscale;

        return sampledFloat;
    }

    

    public float PerlinImage(Vector3 worldPosition)
    {
        int SampleX = Mathf.FloorToInt(worldPosition.x + perlinImageHeight * 0.5f);
        int SampleY = Mathf.FloorToInt(worldPosition.y + perlinImageWidth * 0.5f);

        SampleX = SampleX % perlinNoiseXAxisGrid;
        SampleY = SampleY % perlinNoiseYAxisGrid;

        float sampledValue = CreateNoise(SampleX, SampleY);

        return sampledValue;

    }

    public void GridSpawn()
    {
        GameObject visual = new GameObject("Visual");
        visual.transform.SetParent(this.transform);
//might not need this section
        for (int x = 0; x < perlinNoiseXAxisGrid; x++)
        {
           for (int y = 0; x < perlinNoiseYAxisGrid; y++)
           {
               GameObject prefab = Instantiate(Building, new Vector3( x, CreateNoise(x,y) * perlinHeight, y) 
               +  transform.position, transform.rotation);

               prefab.transform.SetParent(visual.transform);

           } 
        }
        // end

        visual.transform.position = new Vector3(-perlinNoiseXAxisGrid * 0.5f, - perlinHeight, perlinNoiseYAxisGrid * 0.5f);
    }



}
