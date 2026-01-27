using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private bool playerInRange = false;

    void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player entered interaction range. Press F to intereact.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player left interaction range.");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F)) 
        {
            Interact();

    }

        void Interact()
        {
            // Put your interaction logic here (e.g., open a door, pick up an item).
            Debug.Log("Interacting with the object!");
        }
    }
}
