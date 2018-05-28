using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour {

    [Header("Way Points")]
    public static Transform[] points;

    // Use this for initialization
    void Awake()
    {
        GetPositionOfWayPoints();
    }

    /// <summary>
    /// Get position of all waypoint on game
    /// </summary>
    void GetPositionOfWayPoints()
    {
        points = new Transform[transform.childCount];

        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
