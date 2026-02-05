using UnityEngine;

public class AttackForAnimator : MonoBehaviour
{
    Animator animator;
    private float buttonHoldTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Player Mouse Click");
            animator.SetBool("isPunching", true);
        }

        if (Input.GetKey(KeyCode.Mouse0)){
            buttonHoldTime += 1;
            Debug.Log("Button Hold Time: " + buttonHoldTime);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) || buttonHoldTime > 5)
        {
            buttonHoldTime = 0.0f;
            animator.SetBool("isPunching", false);
        }
    }
}