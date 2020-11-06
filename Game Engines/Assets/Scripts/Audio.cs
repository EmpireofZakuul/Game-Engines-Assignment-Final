using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public static float[] AudioSamples = new float[64];
    public AudioClip[] audioClips;
    public AudioListener audioListener;
  //  public static int samplesOfCubes = 64;

    // Start is called before the first frame update
    void Start()
    {
        audioListener = GetComponent<AudioListener>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }


   
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            PlayRandom();
            //AudioSpectrum();
            
        }
        AudioSpectrum();
    }

    public void AudioSpectrum()
    {
        audioSource.GetSpectrumData(AudioSamples, 0, FFTWindow.Blackman);
    }

    void PlayRandom()
    {
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
       

    }
}
