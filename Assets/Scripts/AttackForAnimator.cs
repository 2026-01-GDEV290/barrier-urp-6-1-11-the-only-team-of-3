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
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Player Key G Down");
            animator.SetBool("isPunching", true);
        }

        if (Input.GetKey(KeyCode.G)){
            buttonHoldTime += 1;
            Debug.Log("Button Hold Time: " + buttonHoldTime);
        }

        if (Input.GetKeyUp(KeyCode.G) || buttonHoldTime > 5)
        {
            buttonHoldTime = 0.0f;
            animator.SetBool("isPunching", false);
        }
    }
}