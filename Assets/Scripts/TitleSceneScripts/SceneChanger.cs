using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger: MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SceneLoad()
    {
        SceneManager.LoadScene("main");
    }
}
