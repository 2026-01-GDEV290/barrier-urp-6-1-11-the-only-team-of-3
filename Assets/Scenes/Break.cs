using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject fractured;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            BreakTheThing();
    }

    public void BreakTheThing()
    { Instantiate(fractured, transform.position, transform.rotation);
        Destroy(gameObject);
    } 
}
