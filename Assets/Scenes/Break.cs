using UnityEngine;

public class Break : MonoBehaviour
{
    public GameObject fractured;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            BreakTheThing();
    }

    public void BreakTheThing()
    { Instantiate(fractured, transform.position, transform.rotation);
        Destroy(gameObject);
    } 
}
