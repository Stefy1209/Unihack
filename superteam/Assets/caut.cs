using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEditor;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class caut : MonoBehaviour
{
    public TMP_Text err;
    public TMP_Text fin;
    string[] v = { "5", "7", "8" };
    int i = 0;
    RaycastHit hit;
    Transform noObj = null;
    public GameObject[] cub,canva;
    void Start()
    {
        err.text = "";
        fin.text = "";
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit, 100))
        {
            if (!noObj)
            {
                err.text = "";
                if (i == 3)
                {
                    
                    SceneManager.LoadScene("congrats2");
                }
                noObj = hit.transform;
                if (noObj.name == v[i])
                {
                    canva[Convert.ToInt32(v[i])-1].SetActive(true);
                    i++; noObj = null;
                    if (i == 3)
                    {
                        for (int i = 0; i <= 8; ++i)
                            canva[i].SetActive(true);
                        fin.text = "Tap to continue";
                    }
                }
                else { noObj = null; err.text = "Try again"; }
            }
        }
    }
}
