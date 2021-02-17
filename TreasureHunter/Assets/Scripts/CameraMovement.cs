using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static float m_camera_speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // camera movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0, 0, 1 * m_camera_speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, 0, -1 * m_camera_speed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(1 * m_camera_speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-1 * m_camera_speed * Time.deltaTime, 0, 0));
        }
    }
}
