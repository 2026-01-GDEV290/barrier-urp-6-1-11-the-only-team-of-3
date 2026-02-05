using System;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public Collider Area;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        //Locate closest point on collider to player
        Vector3 closestPoint = Area.ClosestPoint(Player.transform.position);
        //Set position to closest point to player
        transform.position = closestPoint;
        
    }
}
