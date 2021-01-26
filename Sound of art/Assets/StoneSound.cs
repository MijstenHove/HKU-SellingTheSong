using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] AudioList;
    static AudioSource audioSrc;


    void Start()
    {
        AudioList = new AudioClip[]{(AudioClip)Resources.Load("Stone1"),
                                     (AudioClip)Resources.Load("Stone2"),
                                     (AudioClip)Resources.Load("Stone3"),
                                     (AudioClip)Resources.Load("Stone4"),
                                     (AudioClip)Resources.Load("Stone5")};

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider collision)
    {
        Debug.Log("KAAS!");
        AudioClip r = AudioList[Random.Range(0, AudioList.Length)];
        audioSrc.PlayOneShot(r, 0.3F);
    }
}
