using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPIN : MonoBehaviour
{
    Vector3 spin;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        spin = new Vector3(5f, 5f, 0f);
        transform.Rotate(spin);
        
    }
}
