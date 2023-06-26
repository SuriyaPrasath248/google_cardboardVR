using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour

{   public float changetime=0f;


    public void Update()
    {
        changetime += Time.deltaTime;
        if (changetime >= 2)
        {
            ChangeScene();
        }
        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("original");
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
