using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAmeManager : MonoBehaviour
{
    public static GAmeManager instance;
    void Start()
    {
        instance = this;
    }

   
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
