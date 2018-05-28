using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBull : MonoBehaviour {

    [Header("bullet")]
    public Rigidbody rb;
    private float lifeTimeOfBullet = 60;
    public float speedOfEnemyBull = 1;


    [Header("Destination of bullet")]
    Vector3 dir;
    private Vector3 destinationOfBull;

    // Use this for initialization
    void Start()
    {
        GetComponents();
        CalculateTarget();
    }

    /// <summary>
    /// Destroy object if On Trigger Enter 
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemybull") return;
        if (other.tag == "bar") return;

        Destroy(gameObject);
    }

      /// <summary>
      /// Calculate target of bulllet; 
      /// </summary>
     void CalculateTarget()
     {

     if (PlayerControler.MyPosition == null) return;

      destinationOfBull = PlayerControler.MyPosition.transform.position;

      dir = destinationOfBull - this.transform.position;
      }

    /// <summary>
    /// Get components. 
    /// </summary>
    void GetComponents()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Motion of bullet; 
    /// </summary>
    void BullGoesStraight()
    {
        rb.MovePosition(transform.position + (dir * speedOfEnemyBull * Time.deltaTime));
    }
    
    /// <summary>
    /// Check lifeTime of bullet.
    /// </summary>
    void CheckLiveTimeOfBullet()
    {
        lifeTimeOfBullet -= Time.deltaTime;

        if (lifeTimeOfBullet<0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
       CheckLiveTimeOfBullet();
       BullGoesStraight();
    }
}
