using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    [Header("Player")]
    public static volatile Transform MyPosition;
    public static int life = 3;


    [Header("Level Manager")]
    public LevelManager levelManager;


    private void Awake()
    {
        MyPosition = this.transform;
        TurnOffMouse();
        life = 3;   
    }

    private void Start()
    {
        MyPosition = transform;
    }

    // Update is called once per frames
    void Update()
    {
        MyPosition = this.transform;
    }


    /// <summary>
    /// Check player life. 
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        life--;
        if (life <= 0)
        {
            TurnOnMouse();
            levelManager.LoadSceneInt((int)LevelManager.Scenes.GameOver);
        }
    }

    /// <summary>
    /// Turn On visible of mouse
    /// </summary>
    public static void TurnOnMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    /// <summary>
    /// Turn Off visible of mouse
    /// </summary>
    public static void TurnOffMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
