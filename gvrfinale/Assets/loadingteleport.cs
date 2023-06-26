using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class loadingteleport : MonoBehaviour
{
    public float mytime =0f;
    public Transform Radialprogress;
    public GameObject player;

    
    void Start()
    {
         Radialprogress.GetComponent<Image>().fillAmount = mytime;
    }

    
    public void Update()
    {
        mytime += Time.deltaTime;
        Radialprogress.GetComponent<Image>().fillAmount = mytime;
        if ( mytime >= 1)
        {
            teleporting();
        }
        
    }

    public void Reset() {
        mytime = 0f;
         Radialprogress.GetComponent<Image>().fillAmount = mytime;
        
    }
    public void teleporting()
    {
       player.transform.position = new Vector3(transform.position.x,transform.position.y+0.5f,transform.position.z);
    }
}
