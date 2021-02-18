using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60f;
    // Start is called before the first frame update
    Text timerText;
    void Start()
    {
        timerText = GameObject.Find("Timer").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if(Mathf.Round(timer) == 0 && PlayerMovement.playerWin == false)
        {
            Debug.Log("You Lose");
        }

        timerText.text = Mathf.Round(timer).ToString();
    }
}
