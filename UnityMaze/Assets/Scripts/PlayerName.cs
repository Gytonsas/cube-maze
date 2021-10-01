using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {

    public InputField nameText;

    public static string playerName;
	// Use this for initialization
	
	
	// Update is called once per frame
	public void OnSubmit() {
        playerName = nameText.text;
        PostToDatabase();

	}

    private void PostToDatabase()
    {
        User user = new User();
       RestClient.Put("https://maze-project-c716b.firebaseio.com/"+playerName+".json", user);
    }

    private User RetrieveFromDatabase()
    {
        RestClient.Get<User>("https://maze-project-c716b.firebaseio.com/" + playerName + ".json").Then(response =>
        {
            return response;
        });
        return null;
    }
}
