using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{

    public float totalTime = 30f;
    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        else
        {
            totalTime = 0;
            //if (totalTime <= 0)
            //{
            //    Application.Quit();
            //}
        }
        /*{
            GameOver();
            totalTime = 0;
        }*/
        DisplayTime(totalTime);
        
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void GameOver()
    {
    if (totalTime <= 0)
    {
        Application.Quit();
    }
    }
}
