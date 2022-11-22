using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TMP_Text scoreText;

    public int score = 0;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
