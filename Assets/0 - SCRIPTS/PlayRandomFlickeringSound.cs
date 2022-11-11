using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomFlickeringSound : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomFlickerSound()
    {
        int randomIndex = Random.Range(0, audioClips.Length);
        audioSource.PlayOneShot(audioClips[randomIndex]);
    }

}
