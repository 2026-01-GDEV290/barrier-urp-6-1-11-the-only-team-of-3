using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public Transform destination;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
       player.transform.position = destination.transform.position;
        //makes one position = another
    }
}
