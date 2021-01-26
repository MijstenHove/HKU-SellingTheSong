using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C_mouseKlik : MonoBehaviour
{

    public Material canvas;
    public int loadSceneNumb;

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
        if (Input.GetMouseButtonUp(0)&& go.name == gameObject.name)
        {
            if (loadSceneNumb == 0)
            {//menu
                SceneManager.LoadScene(0);
            }
            if (loadSceneNumb == 1)
            {//main
                SceneManager.LoadScene(1);
            }
            if (loadSceneNumb == 2)
            {//scene1
                SceneManager.LoadScene(2);
            }
        }
    }


    // change color
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

