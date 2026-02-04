using UnityEngine;

public class ChangeMelons : MonoBehaviour
{

    public GameObject[] melons;

    [SerializeField] private int hitCount = 0;

    private bool readinput = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            readinput = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            readinput = false;
        }
    }

    private void OnTriggerStay(Collider other)
    { 
        if (other.gameObject.CompareTag("Player"))
        {  

        }
    }
   
    void Update()
    {
        if ((readinput) && (Input.GetMouseButtonDown(0)))
        {
            hitCount = hitCount + 1;
            // Looping Cycle for Array of game Objects
            //if (hitCount > 3)
            //{
            //    hitCount = 0;
            //}
            UpdateMelons();

        }

    }

    private void UpdateMelons()
    {
        for (int i = 0; i < melons.Length; i++)
        {
            if (i == hitCount)
                melons[i].gameObject.SetActive(true);
            else
                melons[i].gameObject.SetActive(false);
        }
    }
}
