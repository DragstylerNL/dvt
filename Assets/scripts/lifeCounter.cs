using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeCounter : MonoBehaviour {

    public int Lives = 3;
    public Text text;

    void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
            Lives--;
            UpdateUI();
            if (Lives <= 0)
            {
                print("Game Over");
            }

        }

    }

    void UpdateUI()
    {
        text.text = "Lives: " + Lives.ToString();
    }
}
