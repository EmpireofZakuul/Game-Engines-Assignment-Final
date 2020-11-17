using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int spaceBetween = 1;

    private Texture2D texture;
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

    public void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GeneratePerlinTexture();
    }

    public Texture2D GeneratePerlinTexture()
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

        return texture;
    }

    Color Noise(int x, int y)
    {
        float XCoordinate = (float)x / perlinImageWidth * scaleOfTheNoise + offsetOfThePerlinNoiseTexture.x;
        float YCoordinate = (float)y / perlinImageHeight * scaleOfTheNoise + offsetOfThePerlinNoiseTexture.y;

        float sampled = Mathf.PerlinNoise(XCoordinate, YCoordinate);
        Color ColorOfThePerlin = new Color(sampled, sampled, sampled);

        return ColorOfThePerlin;
    }

    public float SampleNoise(int x, int y)
    {
        int gridStepSizeX = perlinImageHeight / perlinNoiseXAxisGrid;
        int gridStepSizeY = perlinImageWidth / perlinNoiseYAxisGrid;

        float sampledFloat = texture.GetPixel
                   ((Mathf.FloorToInt(x * gridStepSizeX)), (Mathf.FloorToInt(y * gridStepSizeX))).grayscale;

        return sampledFloat;
    }

    

    public float Perlin(Vector3 worldPosition)
    {
        int SampleX = Mathf.FloorToInt(worldPosition.x + perlinImageHeight * .5f);
        int SampleY = Mathf.FloorToInt(worldPosition.y + perlinImageWidth * .5f);

        SampleX = SampleX % perlinNoiseXAxisGrid;
        SampleY = SampleY % perlinNoiseYAxisGrid;

        float sampledValue = SampleNoise(SampleX, SampleY);

        return sampledValue;

    }

    public void Grid()
    {
        
    }



}
