using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
	public AudioMixer mixer;
	public Slider volumeSlider;
	float currentVolume;

 	
	public void SetVolume(float volume)
	{
		mixer.SetFloat("Volume", volume);
		currentVolume = volume;
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
