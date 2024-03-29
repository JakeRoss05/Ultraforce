using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false; // This variable will be used to check if the game is paused or not
    public GameObject PauseMenuCanvas; // This variable will be used to store the PauseMenuCanvas GameObject

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f; // This line will make sure that the game is not paused when it starts
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // This line will check if the player has pressed the Escape key
        {
            if(Paused) // This line will check if the game is already paused
            {
                Play(); // This line will call the Resume function
            }
            else
            {
                Stop(); // This line will call the Pause function
            }
        }
    }

    void Stop()
    {
        PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f; // This line will pause the game 
        Paused = true; // This line will set the Paused variable to true
    }
    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f; // This line will pause the game
        Paused = false; // This line will set the Paused variable to true
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu"); // This line will load the MainMenu scene
    }
}
