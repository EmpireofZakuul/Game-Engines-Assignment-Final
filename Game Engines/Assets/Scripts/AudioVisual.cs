using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisual : MonoBehaviour
{
    public GameObject cubesPrefab;
    GameObject[] cubes = new GameObject[64];
    public float scaleMax;
    public  const float sampleAngle = 360.0f/64;
    public float radius = 15;
    public float padding = 2;
    public float scale = 0.075f;
    public float intensity;




    // Start is called before the first frame update
    void Start()
    {
       for( int i = 0; i < Audio.AudioSamples?.Length; i++)
       {
          // GameObject SpawnCube = (GameObject)Instantiate(cubesPrefab);
          
           // SpawnCube.transform.position = this.transform.position;
            
            GameObject SpawnCube = (GameObject)Instantiate(cubesPrefab, transform.position, cubesPrefab.transform.rotation) as GameObject;
            SpawnCube.transform.Rotate(0f, 180f, 0f);
            SpawnCube.transform.SetParent(transform, false);

            this.transform.eulerAngles = new Vector3(0, sampleAngle * i, 0);
            SpawnCube.transform.position = Vector3.forward * radius;
            SpawnCube.transform.localPosition = new Vector3(SpawnCube.transform.localPosition.x, 0, SpawnCube.transform.localPosition.z);
            cubes[i] = SpawnCube;
            Renderer r = SpawnCube.GetComponent<Renderer>();
            r.material.SetColor("_EmissionColor", Color.HSVToRGB(1f / Audio.AudioSamples.Length * i, 1f, 1f) * intensity);
           // r.material.color = Color.HSVToRGB(1f / Audio.AudioSamples.Length * i, 1f, 1f);
        }
        //Grid();
    }

    // Update is called once per frame
    void Update()
    {
        if (cubes == null) return;
        for (int i = 0; i < Audio.AudioSamples?.Length; i++)
        {
            float y = (Audio.AudioSamples[i] * scaleMax) + padding;
            cubes[i].transform.localScale = new Vector3(scale, y, scale);
        }
    }   
}
