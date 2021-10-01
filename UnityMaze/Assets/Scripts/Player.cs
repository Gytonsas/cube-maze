using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DitzeGames.MobileJoystick;
using UnityStandardAssets.Characters.FirstPerson;


public class Player : MonoBehaviour
{

    protected Joystick Joystick;
    protected Button Button;
    protected TouchField TouchField;

    // Use this for initialization
    void Awake()
    {
        Joystick = FindObjectOfType<Joystick>();
        Button = FindObjectOfType<Button>();
        TouchField = FindObjectOfType<TouchField>();
    }

    // Update is called once per frame
    void Update()
    {
    //    transform.position = new Vector3(transform.position.x + Joystick.AxisNormalized.x * Time.deltaTime);
    }
}
