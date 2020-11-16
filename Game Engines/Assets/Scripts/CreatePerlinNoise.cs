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



    void OnEnable()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GeneratePerlinTexture();
    }

    public Texture2D GeneratePerlinTexture()
    {
        if (randomizeTexture)
        {
            offsetOfThePerlinNoiseTexture = new Vector2(Random.Range(0, 99999), Random.Range(0, 99999));
        }

        Texture2D texture = new Texture2D(perlinImageWidth, perlinImageHeight);

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


}
