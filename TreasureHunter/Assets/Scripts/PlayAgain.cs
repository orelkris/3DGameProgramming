using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void LoadTerrain()
    {
        Debug.Log("Landscape Scene Loading");
        SceneManager.LoadScene("TreasureHunter2");
    }
}
