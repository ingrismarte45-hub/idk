// MenuSystem.cs

using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{
    public GameObject menuPanel;
    public Button startButton;
    public Button optionsButton;
    public Button exitButton;

    private void Start()
    {
        menuPanel.SetActive(false);
        startButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(OpenOptions);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void ToggleMenu()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
    }

    private void StartGame()
    {
        // Logic for starting the game
        Debug.Log("Game Started");
        menuPanel.SetActive(false);
    }

    private void OpenOptions()
    {
        // Logic for opening options
        Debug.Log("Options Opened");
    }

    private void ExitGame()
    {
        // Logic for exiting the game
        Debug.Log("Game Exited");
        Application.Quit();
    }
}