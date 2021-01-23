using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAudio : MonoBehaviour
{

    public ParticleSystem ParticleAudios;
    public static AudioClip PS1;
    public static AudioClip PS2;
    public static AudioClip PS3;
    public static AudioClip PS4;
    public static AudioClip PS5;
    public AudioClip[] AudioList;
    //public ArrayList[] audiofiles = new AudioList[] { PS1, PS2, PS3, PS4, PS5 };
    static AudioSource audioSrc;
    // Start is called before the first frame update


    void Start()
    {
        //PS1 = Resources.Load<AudioClip>("PS1");
        //PS2 = Resources.Load<AudioClip>("PS2");
        //PS3 = Resources.Load<AudioClip>("PS3");
        //PS4 = Resources.Load<AudioClip>("PS4");
        //PS5 = Resources.Load<AudioClip>("PS5");
        AudioList = new AudioClip[]{(AudioClip)Resources.Load("PS1"),
                                     (AudioClip)Resources.Load("PS2"),
                                     (AudioClip)Resources.Load("PS3"),
                                     (AudioClip)Resources.Load("PS4"),
                                     (AudioClip)Resources.Load("PS5")};

        audioSrc = GetComponent <AudioSource> ();
    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("KAAS!");
        Debug.Log(AudioList);
        //audioSrc.PlayOneShot(PS1, 0.3F);
        AudioClip r = AudioList[Random.Range(0, AudioList.Length)];
        Debug.Log(r);
        audioSrc.PlayOneShot(r, 0.3F);
        //audioSrc.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
