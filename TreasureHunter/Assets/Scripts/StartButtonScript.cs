using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public void LoadTerrain()
    {
        Debug.Log("Terrain Scene Loading");
        SceneManager.LoadScene("");
    }
}
