using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    [Header("Stats Text")]
    public Text shotText;
    public Text hitText;
    public Text accText;

    [Header("Stats Text")]
    public GameObject MyUI;
    public static bool pauseOn = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            TooglePause();
        }
        CheckStats();
    }

    /// <summary>
    /// Check And Set stats in UI
    /// </summary>
    void CheckStats()
    {
        float shot = PlayerStats.shotPerRound;
        float hit = PlayerStats.hitPerRound;

        shotText.text = shot.ToString();
        hitText.text = PlayerStats.hitPerRound.ToString();

        if (shot != 0)
        {
            accText.text = (hit * 100 / shot).ToString();
        }
        else
        {
            accText.text = "shoot";
        }
    }

    /// <summary>
    /// On or Off Pause in Game
    /// </summary>
    public void TooglePause()
    {
        pauseOn = !pauseOn;

        MyUI.SetActive(pauseOn);

        if (MyUI.activeSelf)
        {
            PlayerControler.TurnOnMouse();

            Time.timeScale = 0f;
        }
        else
        {
            PlayerControler.TurnOffMouse();

            Time.timeScale = 1f;
        }
    }
}
