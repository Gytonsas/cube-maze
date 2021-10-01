using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User : MonoBehaviour
{
    public string userName;

    public User()
    {
        userName = PlayerName.playerName;
    }
}
