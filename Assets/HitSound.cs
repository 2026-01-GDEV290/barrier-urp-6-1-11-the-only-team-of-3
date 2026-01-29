using UnityEngine;

public class HitSound : MonoBehaviour
{

    public AudioClip destroySound;
    public float volume = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource.PlayClipAtPoint(destroySound, transform.position, volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
