using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public bool shakeStart = false;
    public float duration = 1f;
    public float shakeIntensity = 1f;

    public AnimationCurve shakeCurve;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(shakeStart)
        {
            shakeStart = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;
        
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = shakeCurve.Evaluate(elapsedTime/duration);
            transform.position = startPosition + (Random.insideUnitSphere * strength)* shakeIntensity;
            yield return null;
        }

        transform.position = startPosition;
    }
    
    /* startCameraShake - Starts a default camera shake
     */

    public void StartCameraShake()
    {
        shakeStart = true;
    }

    /* startCameraShake - Starts camera shake with the set duration and intensity given by the parameters
     * @param _duration - Sets the duration of the camera shake
     * @param _intensity - Sets the intensity of the camera shake
     */
    public void StartCameraShake(int _duration, int _intensity)
    {
        duration = _duration;
        shakeIntensity = _intensity;
        shakeStart=true;
    }
}
