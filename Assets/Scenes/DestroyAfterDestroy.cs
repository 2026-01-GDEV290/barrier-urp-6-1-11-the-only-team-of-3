using UnityEngine;

public class DestroyAfterDestroy : MonoBehaviour
{
    public float destroyDelay = 3.0f;
    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }

}
