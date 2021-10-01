using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour {

	
	public void Quit () {
       Debug.Log("APPLICATION QUIT");
      Application.Quit();
	}
	
	// Update is called once per frame
	public void Retry () {
   //    Application.LoadLevel(Application.loadedLevel);
     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
}
