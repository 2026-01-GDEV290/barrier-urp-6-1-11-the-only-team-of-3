using Unity.VisualScripting;
using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject fractured;
    public AudioClip destroySound;
    public float volume = 1.0f;

  

    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.F))
       //     BreakTheThing();   
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          if (Input.GetKeyDown(KeyCode.F))
              BreakTheThing();
        }
    }


    public void BreakTheThing()
    { Instantiate(fractured, transform.position, transform.rotation);
        
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(destroySound, transform.position, volume);

    }
}
