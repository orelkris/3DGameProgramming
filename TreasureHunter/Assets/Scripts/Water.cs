using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // find the player object
        GameObject player = GameObject.Find("PlayerCube");

        // if the player has entered the water collider, slow the player down
        if (this.GetComponent<Collider>().bounds.Contains(player.transform.position))
        {
            PlayerMovement.m_player_speed = 10;
        }

        // if the player is out of the bounds of the water collider, speed the player up
        else
        {
            PlayerMovement.m_player_speed = 20;
        }
    }
}
