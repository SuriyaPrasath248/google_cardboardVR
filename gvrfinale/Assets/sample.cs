/* 
 This script can be placed on an empty game object.

 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{

    public GameObject explosion;
    public GameObject firestimulation;
    public GameObject damn;
    public GameObject Player2;
    public GameObject button1;
    public float dist =0f;
    
 
    public void Foo() 
    {   dist = Vector3.Distance(Player2.transform.position,button1.transform.position);
       if(dist<=4){
        StartCoroutine(TemporarilyDeactivate(5));
       } 
    }
 
    private IEnumerator TemporarilyDeactivate(float duration) 
    {
        explosion.SetActive(false);
        firestimulation.SetActive(false);
        yield return new WaitForSeconds(duration);
        explosion.SetActive(true);
        explosion.GetComponent<AudioSource>().enabled = true;
        firestimulation.SetActive(true);
         firestimulation.GetComponent<AudioSource>().enabled = true;
        Destroy(damn);
      
        
    }
    
    
}
   

