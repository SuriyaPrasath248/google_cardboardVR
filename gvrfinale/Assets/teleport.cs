using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;

    public void Teleportplayer()
    {
        player.transform.position = new Vector3(transform.position.x,transform.position.y+0.1f,transform.position.z);
    }
}
