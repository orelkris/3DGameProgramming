using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static float m_player_speed = 20f;
    // Start is called before the first frame update
    public static bool playerWin = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if player collides with the treasure, the player wins! Show "Win" screen
        if (this.GetComponent<Collider>().bounds.Contains(GameObject.Find("Treasure").transform.position))
        {
            playerWin = true;
            SceneManager.LoadScene("Win");
        }

        // player movement
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }

        this.transform.Translate(movement.normalized * m_player_speed * Time.deltaTime);

        // player rotation
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(new Vector3(0, 40 * Time.deltaTime, 0));
           
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(new Vector3(0, -40 * Time.deltaTime, 0));
        }

        // on every update, make sure the height of the player is always on the surface of the terrain
        // by matching the height of the terrain at the x and z position of the player (+3)
        Vector3 newPlayerLocation = this.transform.position;
        newPlayerLocation.y = Terrain.activeTerrain.SampleHeight(this.transform.position) + 3;
        this.transform.position = newPlayerLocation;
    }
}
