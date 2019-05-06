using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnGUI()
    {
        GUI.Label(new Rect((Screen.width / 2) - 40, 50, 80, 30), "Welcome");
        if (GUI.Button(new Rect(Screen.width / 2 -100, 250, 200, 30), "Start a New Game"))
        {
            Application.LoadLevel(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
