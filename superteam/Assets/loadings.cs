using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadings : MonoBehaviour
{
    void Start()
    {
        Invoke("FunctionScene", 3f);
    }
    void FunctionScene()
    {
        SceneManager.LoadScene("s1");
    }
    void Update()
    {

    }
}