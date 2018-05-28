using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullScript : MonoBehaviour {

    [Header("enemy")]
    GameObject target;

    [Header("position Of Target")]
    float x, y, z;


    [Header("bullet")]
    public float speed;
    Vector3 targetOne;


    void Awake()
    {
        FindTargetOfBull();
    }

  
    void Update()
    {
        BullGoesStraight();
    }

    /// <summary>
    /// Destoy bullet when on Trigger Enter
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Find Target of bullet
    /// </summary>
    void FindTargetOfBull()
    {
        target = GameObject.FindGameObjectWithTag("MyTarget");

        x = target.transform.position.x;
        y = target.transform.position.y;
        z = target.transform.position.z;
    }

    /// <summary>
    /// Motion of bullet
    /// </summary>
    void BullGoesStraight()
    {

        //if (targetOne == null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}
        

        targetOne = new Vector3(x, y, z);

        Vector3 dir = targetOne - transform.position;

        if (Vector3.Distance(targetOne, transform.position) < 5F)
        {
            Destroy(gameObject);
        }

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }
}

