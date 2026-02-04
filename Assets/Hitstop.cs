using UnityEngine;
using System.Collections;

public class Hitstop : MonoBehaviour
{
    public bool startHitstop = false;
    public bool shakeTarget = false;
    public int hitstopDuration = 0;
    public GameObject target;
    private bool waiting = false;
    
    public AnimationCurve targetShake;

    void Start()
    {
    }
    void Update()
    { 
        if (!waiting)
        {
            startHitstop = false;
        }
        if (startHitstop)
        {
            StartCoroutine(HitstopWait(hitstopDuration));
        }

       
    }
    public void SetHitstop(int _duration)
    {
        hitstopDuration = _duration;
        if (waiting)
        {
            return;
        }
        Time.timeScale = 0.0f;

        Debug.Log("run hitstop");
    }

    public void ShakeTarget(GameObject target, int strength, float duration)
    {
        Vector3 targetPosStart = target.transform.position;
        float currentTimeElapsed = 0.0f;
        

        while (shakeTarget && startHitstop && currentTimeElapsed < duration)
        {
            target.transform.position = targetPosStart + (Random.insideUnitSphere * strength);
            target.transform.position = targetPosStart + (Random.insideUnitSphere / strength);
            target.transform.position = targetPosStart + (Random.insideUnitSphere / strength);
            target.transform.position = targetPosStart;
            currentTimeElapsed = currentTimeElapsed + Time.deltaTime;
        }
    }

    IEnumerator HitstopWait(float duration)
        {
            waiting = true;
            yield return new WaitForSeconds(duration);
            Time.timeScale = 1.0f;
            waiting = false;
        }
    

    
}
