using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

  
    [Header("Prototype for bullet")]
    public GameObject[] bullet;
    public GameObject firepoint;

    [Header("Selected weapon")]
    public WeaponEnum weaponInHeand;
    public Sprite[] guns;

    [Header("Target of Player")]
    public GameObject target;

    [Header("measuring the time between shots")]
    public float counterTimebull;
    public float frekvencyOfBull;


    void Start()
    {
        ChooseGun();
    }

    void Update()
    {
        if (!PauseMenu.pauseOn)
        {
            CheckShoot();
        }
    }

    /// <summary>
    /// Shoot selected bullet. 
    /// </summary>
    void Shoot()
    {
        if (weaponInHeand == WeaponEnum.gun)
        {
            Instantiate(bullet[0], firepoint.transform.position, Quaternion.identity);
            PlayerStats.Shoot();
        }
        else

        if (weaponInHeand == WeaponEnum.redgun)
        {
            Instantiate(bullet[1], firepoint.transform.position, Quaternion.identity);
            PlayerStats.Shoot();
        }
        else
        if (weaponInHeand == WeaponEnum.none)
        {

        }
    }

    /// <summary>
    /// check if can you shoot
    /// </summary>
    void CheckShoot()
    {
        counterTimebull += Time.deltaTime;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (counterTimebull > 1 / frekvencyOfBull)
            {
                //--Shoot--//
                Shoot();

                counterTimebull = 0;
            }
        }
    }
    /// <summary>
    /// Choose type of Gun in game
    /// </summary>
    public void ChooseGun()
    {
        if (weaponInHeand == WeaponEnum.gun)
        {
            this.GetComponent<SpriteRenderer>().sprite = guns[(int)WeaponEnum.gun];
        }
        else

        if (weaponInHeand == WeaponEnum.redgun)
        {
            this.GetComponent<SpriteRenderer>().sprite = guns[(int)WeaponEnum.redgun];
        }
        else
        if (weaponInHeand == WeaponEnum.none)
        {
            this.GetComponent<SpriteRenderer>().sprite = guns[(int)WeaponEnum.none];
        }
    }
}
