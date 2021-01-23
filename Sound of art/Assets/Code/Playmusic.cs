using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playmusic : MonoBehaviour
{
   
     AudioSource artSound;
    // Start is called before the first frame update
    void Start()
    {
       
        artSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "player")
        {
            Debug.Log("dfg");
            artSound.Play();


        }

    }
}
