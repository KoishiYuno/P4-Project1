using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect((Screen.width / 2) - 40, 50, 80, 30), "Game Over");
        GUI.Label(new Rect((Screen.width / 2) - 40, 200, 80, 30), "Score: " + score);
        if (GUI.Button(new Rect(Screen.width / 2 - 30, 250, 60, 30), "Retry?")) {
            Application.LoadLevel(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
