using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_mouseKlik : MonoBehaviour
{
    AudioSource artSound;
    
    void Start()
    {
        artSound = GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            PrintName(hit.transform.gameObject);
        }
        
    }

    void PrintName(GameObject go) 
    {
        print(go.name);
        if (Input.GetMouseButtonUp(0)&& go.name == gameObject.name)
            {
            artSound.Play();
        }
    } 
}

