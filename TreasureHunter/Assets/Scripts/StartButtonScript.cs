using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public void LoadTerrain()
    {
        Debug.Log("Landscape Scene Loading");
        SceneManager.LoadScene("TreasureHunter");
    }
}
