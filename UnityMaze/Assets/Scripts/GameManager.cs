using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour {
    public static int currentScore;
    public static int currentLevel = 1;

    private void Start()
    {
      
        DontDestroyOnLoad(gameObject);
 
   }

    public static void CompleteLevel() {
        if (currentLevel <= 6)
        {

            currentLevel += 1;
            print(currentLevel);

          SceneManager.LoadScene(currentLevel);

        }
        else
        {
            print("You win!");
        }

    }

}
