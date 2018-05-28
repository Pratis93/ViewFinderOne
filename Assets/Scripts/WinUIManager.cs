using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinUIManager : MonoBehaviour {

    [Header("Stats text")]
    public Text shotText;
    public Text hitText;
    public Text life;
    public Text accuText;

   
    void Start()
    {
        CheckAndSetStats();
    }

    /// <summary>
    /// Check and Set stats on Win Scene
    /// </summary>
    void CheckAndSetStats()
    {
        float hitFloat = PlayerStats.hitPerRound;
        float shotFloat = PlayerStats.shootPerRound;

        shotText.text = shotFloat.ToString();
        hitText.text = hitFloat.ToString();

        if (shotFloat != 0)
        {
            accuText.text = (hitFloat * 100 / shotFloat).ToString() + "%";
        }

        life.text = PlayerControler.life.ToString();
    }
}
