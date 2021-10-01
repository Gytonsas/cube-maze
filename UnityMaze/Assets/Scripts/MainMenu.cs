using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[SerializeField]

public class MainMenu : MonoBehaviour {

    public Button level2Button;
    int levelPassed;

    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
      //  level2Button.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level2Button.interactable = true;
                break;

        }
    }

    void EndGame()
    {
        Debug.LogError("Dosnt work");
    }

 
   

    public void levelToLoad (int currentLevel)
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void reserPlayerPrefs()
    {
        level2Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
  }
    
    

