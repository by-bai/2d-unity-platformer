using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //To follow Player, need a reference to the Player's Transform which tells us the position of the Player
    //Player is a different Component, so cannot use GetComponent
    //Therefore, serialise the field so that we can drag Player to the script in Unity.

    [SerializeField] private Transform player;

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        //follow player but
        //transform.position.z -> keep the z value
    }
}
