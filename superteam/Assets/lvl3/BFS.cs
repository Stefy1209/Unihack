using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEditor;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class BFS : MonoBehaviour
{
    public TMP_Text err;
    public TMP_Text fin;
    string[] Nodes = { "Nod 1", "Nod 5", "Nod 7", "Nod 6", "Nod 3", "Nod 2", "Nod 10", "Nod 11", "Nod 4", "Nod 9", "Nod 8"};
    public GameObject[] nod;
    int i = 0;
    RaycastHit hit;
    Transform noObj = null;

    private void Start()
    {
        err.text = "";
        fin.text = "";
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit, 100))
        {
            if(!noObj)
            {
                err.text = "";
                if(i == 11)
                {
                    SceneManager.LoadScene("congrats");
                }
                noObj = hit.transform;
                if(noObj.name == Nodes[i])
                {
                   
                        err.text = "Good Job!";
                        i++;
                        noObj = null;

                }
                else
                {
                    noObj = null; 
                    err.text = "Try again";
                }
            }
        }
    }
}
