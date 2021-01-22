using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAudio : MonoBehaviour
{

    public ParticleSystem ParticleAudios;
    public static AudioClip PS1;
    static AudioSource audioSrc;
    // Start is called before the first frame update


    void Start()
    {
        PS1 = Resources.Load<AudioClip>("PS1");
        audioSrc = GetComponent <AudioSource> ();
    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("KAAS!");
        audioSrc.PlayOneShot(PS1, 0.3F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
