using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smokeoff : MonoBehaviour
{
   public GameObject smoke;
   public float smokedistance =0f;
   public GameObject firesystem;
   public GameObject fireaudio;

 
    void Update()
    {   smokedistance  = Vector3.Distance(smoke.transform.position,firesystem.transform.position);
        if(smokedistance <= 2.5f)
        { 
        smoke.SetActive(true);
        StartCoroutine(TemporarilyDeactivate(3));
        }
    }

   private IEnumerator TemporarilyDeactivate(float duration) 
    {
        
     
      yield return new WaitForSeconds(duration);
      smoke.SetActive(false);
      fireaudio.GetComponent<AudioSource>().enabled = false;
      Invoke("loadnxtscene",2f);
    }

    public void loadnxtscene ()
    {
      SceneManager.LoadScene("Menu");
    }
}
