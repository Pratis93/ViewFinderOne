using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class TankScript : MonoBehaviour {


    [Header("Enemy")]
    public GameObject tank;
    public int speedOfTank=1;

    public int live=2;
    private int liveForbar;

    public Image healthBar;


    [Header("Use Bullets")]
    public GameObject bulletPreFab;
    private float random;
    private float randomOfrandom = 0.5f;

    public float fireRate = 0.2f;
    private float fireCountDown = 0f;
    public Transform firePoint;


    [Header("Use Bullets")]
    private GameObject  positionOfPlayer;

    void Start()
    {
        positionOfPlayer = GameObject.FindGameObjectWithTag("Player");
        liveForbar = live;
    }

    void Update()
    {
        MoveToPlayer();
        Bullet();
    }

    /// <summary>
    /// Set LiveBar above enemy. 
    /// </summary>
    void SetLiveBar()
    {
        if (liveForbar == 0) return;

        healthBar.fillAmount = (float) live / liveForbar;
    }

    /// <summary>
    /// When Trigger is from Player bullet, destroy enemy.
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bull")
        {
            live--;
            PlayerStats.Hit();

            SetLiveBar();

            if (live <= 0)
            {
                EnemySpawner.countOfEnemyOnScene--;
                Destroy(gameObject);
            }
        }
    }

    /// <summary>
    /// Move tank to Player
    /// </summary>
    void MoveToPlayer()
    {
        if (positionOfPlayer == null) return;

       Vector3 dir = positionOfPlayer.transform.position - tank.transform.position;
       tank.transform.Translate(dir.normalized * speedOfTank * Time.deltaTime, Space.World);
    }

    /// <summary>
    /// Shoot bullet by player
    /// </summary>
    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }

    /// <summary>
    /// check if you can shoot
    /// </summary>
    void Bullet()
    {
        if (fireCountDown <= 0f)
        {
           random = Random.Range(0, 1);

            if (random < randomOfrandom)
            {
                Shoot();
                fireCountDown = 1f / fireRate;
            }
        }
        fireCountDown -= Time.deltaTime;
    }
}
