using UnityEngine;

public class PlayerCollisionStuff : MonoBehaviour
{
    public bool myreadinput = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter breakable");
        if (other.gameObject.CompareTag("breakable"))
        {
            SetReadInput(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("breakable"))
        {
            SetReadInput(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("breakable"))
        {

        }
    }

    public void SetReadInput(bool value)
    {
        myreadinput = value;
    }

    public bool GetReadInput()
    {
        return myreadinput;
    }
}
