using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ColourChange : MonoBehaviour
{
     // public float intensity;
      // public GameObject enemeyColour;
    // Start is called before the first frame update
    public float materialspeed;
    public float Intensity;

    private Image _image;
    public Material neonMaterial;
    private	 float m;

    void Start()
    {
       // Renderer r = enemeyColour.GetComponent<Renderer>();
       // r.material.SetColor("_EmissionColor", Color.HSVToRGB(1f, 1f, 1f) * intensity);
        //r.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        _image = GetComponent<Image>();
        
    }

    //private void Start() => _image = GetComponent<Image>();

    void Update()
    {

        m += materialspeed * Time.deltaTime;
        if(_image)
            _image.color = Color.HSVToRGB(m, 1f, 1f);

        if (neonMaterial)
            neonMaterial.SetColor("_EmissionColor", Color.HSVToRGB(m * 1, 1f, 1f) * Intensity);
        if (m > 1f)
            m = 0;
    }
}

