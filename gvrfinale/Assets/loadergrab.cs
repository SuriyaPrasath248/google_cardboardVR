using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class loadergrab : MonoBehaviour
{   
    public float gmytime =0f;
    public Transform gRadialprogress;
    public GameObject grabsystem;

    
    void Start()
    {
         gRadialprogress.GetComponent<Image>().fillAmount = gmytime;
    }

    
    public void Update()
    {
        gmytime += Time.deltaTime;
        gRadialprogress.GetComponent<Image>().fillAmount = gmytime;
        if ( gmytime >= 1)
        {
            grabbing();
        }
        
    }

    public void Reset() {
        Debug.Log("hi");
        
        gmytime = 0f;
         gRadialprogress.GetComponent<Image>().fillAmount = gmytime;
        
    }
    public void grabbing()
    {
        grabsystem.SetActive(true);
    }
}
