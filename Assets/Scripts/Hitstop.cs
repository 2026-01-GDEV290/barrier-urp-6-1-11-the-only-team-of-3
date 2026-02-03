using UnityEngine;
using System.Collections;

public class Hitstop
{
    bool waiting = false;
    public void SetHitstop(int duration)
    {
        if (waiting)
        {
            return;
        }
        Time.timeScale = 0.0f;

        IEnumerator Wait(float duration)
        {
            waiting = true;
            yield return new WaitForSeconds(duration);
            Time.timeScale = 1.0f;
            waiting = false;
        }
    }
}
