using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_soundklik : MonoBehaviour
{
    //  public GameObject particals;
     AudioSource artSound;
     public Material canvas;

    void Start()
    {
        artSound = GetComponent<AudioSource>();
       // canvas = GetComponent<Material>();
        // particals.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            PrintName(hit.transform.gameObject);
            HoverShine(hit.transform.gameObject);
        }

    }

    void PrintName(GameObject go)
    {
        // print(go.name);
        if (Input.GetMouseButtonUp(0) && go.name == gameObject.name)
        {
             artSound.Play();
            // particals.SetActive(true);
            
        }
    }



    void HoverShine(GameObject go)
    {
        if (go.name == gameObject.name)
        {
            canvas.color = Color.gray;
        }
        else
            canvas.color = Color.white;

    }
}
