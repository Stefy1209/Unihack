using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEditor;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public TMP_Text err;
    public TMP_Text fin;
    string [] v = { "3", "2", "5", "3", "5" ,"4","5","7"};
    string [] vv = { "2", "1", "3", "2", "4" ,"3","4","6"};
    int i = 0,j=0;
    RaycastHit hit;
    Transform noObj  = null;
  Transform switchObj  = null;
  Vector3 tempObj ;
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
                if (i == 8)
                {
                    fin.text = "Tap to continue";
                    SceneManager.LoadScene("congrats1");
                }
                
                noObj = hit.transform;
                if (noObj.name == v[i])
                {
                    tempObj = noObj.transform.position;
                }
                else { noObj = null; err.text = "Try again"; }
            }
            else if (noObj != null)
            { 
                err.text = "";
                switchObj = hit.transform;
                if (switchObj.name == vv[j])
                {
                    DoTheSwitch(); j++; i++;
                    if(i==8)
                        fin.text = "Tap to continue";

                }
                else { switchObj = null; err.text = "Try again"; }

            }
            
        }
    }

    void DoTheSwitch()
    {
        noObj.transform.position = switchObj.transform.position;
        switchObj.transform.position = tempObj;
        noObj = null;
    }
}
