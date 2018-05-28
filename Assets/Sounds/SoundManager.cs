using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    [Header("Sounds")]
    public AudioClip shoot;
    public AudioClip hit;

    private AudioSource audioPlay;

    private void Awake()
    {
        audioPlay = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Play hit sound
    /// </summary>
    public void PlayHit()
    {
        audioPlay.clip = hit;
        audioPlay.Play();
    }
    /// <summary>
    /// Play shoot sound
    /// </summary>
    public  void PlayShoot()
    {
        audioPlay.clip = shoot;
        audioPlay.Play();
    }
}


