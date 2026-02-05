using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance;
    public bool shakeStart = false;
    public float duration = 1f;
    public float shakeIntensity = 1f;
    private float enumElapsedTime = 0f;

    

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
            enumElapsedTime = elapsedTime;
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
    public void StartCameraShake(float _duration, float _intensity)
    {
        duration = _duration;
        shakeIntensity = _intensity;
        shakeStart=true;

        Debug.Log("run camera shake");
    }

    /* setTweenType - Sets the tween type of the camera shake curve
     * @param _tweenType - The type of tween to use for the camera shake curve. Can choose between Linear, Ease In, and Constant.
     * @param optionalvalue - Optional value parameter, use if you want a constant curve type that uses a different shake curve key. Default key: 1.
     */
    public void setTweenType(string _tweenType, int optionalvalue = 1)
    {
        if (_tweenType.Equals("EaseIn") || _tweenType.Equals("Ease In") || _tweenType.Equals("ease in") || _tweenType.Equals("easein"))
        {
            shakeCurve = AnimationCurve.EaseInOut(enumElapsedTime, shakeCurve.keys[1].value, (enumElapsedTime * duration) + 1, shakeCurve.keys[2].value);
        }

        if (_tweenType.Equals("Linear") || _tweenType.Equals("linear"))
        {
            shakeCurve = AnimationCurve.Linear(enumElapsedTime, shakeCurve.keys[1].value, (enumElapsedTime * duration) + 1, shakeCurve.keys[2].value);
        }

        if (_tweenType.Equals("Constant") || _tweenType.Equals("constant"))
        {
            shakeCurve = AnimationCurve.Constant(enumElapsedTime, (enumElapsedTime * duration) + 1, shakeCurve.keys[optionalvalue].value);
        }
    }
}
