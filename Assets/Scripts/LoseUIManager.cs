using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseUIManager : MonoBehaviour {


    [Header("Stats Text")]
    public Text accuText;
    public Text hitText;
    public Text shotText;

    void Start()
    {
        CheckAndSetStats();
    }

    /// <summary>
    /// Check and Set Stats in Lose Scene
    /// </summary>
    void CheckAndSetStats()
    {
        float hitFloat = PlayerStats.hitPerRound;
        float shotFloat = PlayerStats.shotPerRound;

        shotText.text = shotFloat.ToString();
        hitText.text = hitFloat.ToString();

        if (shotFloat != 0)
        {
            accuText.text = (hitFloat * 100 / shotFloat).ToString() + "%";
        }
    }
}
