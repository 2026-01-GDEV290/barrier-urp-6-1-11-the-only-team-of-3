using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerObject;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerObject.SetActive(false);
            player.position = destination.position;
            playerObject.SetActive(true);
        }
    }
}
