using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEditor;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class stiva : MonoBehaviour
{
    static int cnt=0;
    public GameObject[] cub;
    public TMP_Text ful, emp;
     public void up()
    {
        ful.text = "";
        emp.text = "";
        if (cnt <= 7)
        { cub[cnt].SetActive(true); cnt++; }
        else { ful.text = "Full Stack!"; cnt=7; }
    }
    public void down()
    {
        ful.text = "";
        emp.text = "";
        if (cnt >= 0)
        { cub[cnt].SetActive(false); cnt--; }
        else { emp.text = "Empty Stack!"; cnt = 0; }
    }

}
