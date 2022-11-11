using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomFlickeringLights : MonoBehaviour
{
    // lights can call an instance of this class
    // and use it to apply a customizable variety of light flicker properties 
    // we should be able to adjust total flicker time, number of times on/off,
    // length of individual flicker, randomization
    //


    // light intensity needs to be on and off for random amounts(within range)
    // of time at a random number of times

    public Light light;
    public int flickerCount;

    float flickerDuration;
    public float minDuration;
    public float maxDuration;

    public float lightIntensity;
    public List<float> intensityList;

    AnimationClip clip;



    private void Start()
    {
        light = this.GetComponent<Light>();

        light.gameObject.AddComponent<Animation>();
        light.gameObject.AddComponent<Animator>();
     
        Animator animator = this.GetComponent<Animator>();
        Animation animation = this.GetComponent<Animation>();

        animation.clip = clip;
        

        //light intensity can vary between 0 and 3
        //float randomLightIntensity = Random.Range(0, 3);
        //light.intensity = randomLightIntensity;

        //List<float> intensityList = new List<float>();  

        //for a number of times, light intensity HAS to be zero

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LightFlickerRandomizer();

        }

    }

    private void LightFlickerRandomizer()
    {
        for (int i = 0; i < flickerCount; i++)
        {
            lightIntensity = Random.Range(0, 3);
            flickerDuration = Random.Range(0.1f, 1.2f);
            light.intensity = lightIntensity;
            Debug.Log(lightIntensity);
            Debug.Log(flickerDuration);

            intensityList.Add(lightIntensity);
            

        }

    }
}
