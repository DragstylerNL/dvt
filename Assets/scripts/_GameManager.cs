using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class _GameManager : MonoBehaviour {

    public int Score = 0;
    public int HighScore = 0;
    public Text text_Score;
    public Text text_HighScore;

    void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void score()
    {
        Score++;
        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        text_Score.text = "Score: " + Score.ToString();
        text_HighScore.text = "HighScore: " + HighScore.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other);
        score();
        CameraShaker.Instance.ShakeOnce(4f, 4f, 1f, 1f);
    }


    
}
