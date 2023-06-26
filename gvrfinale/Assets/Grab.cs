using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{   
    public Transform myhand;
    public Rigidbody extin;
    public GameObject Player;
    public GameObject Cylinder;
    public float grabdistance;


    void Start()
    {
        grabdistance =Vector3.Distance(Player.transform.position,Cylinder.transform.position);
        if (grabdistance <= 5)
        {
            extin.transform.parent = myhand.transform;
            extin.transform.localPosition = myhand.transform.localPosition;
        }
        
    }

    
}
