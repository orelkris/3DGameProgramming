using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    public void ExitGameplay()
    {
        EditorApplication.ExitPlaymode();
        Debug.Log("Game is exiting");
    }
}
