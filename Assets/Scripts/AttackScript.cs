using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField] private int hitCount = 0;

    private bool readinput = false;
    private float buttonHoldTime;
    
    Animator animator;
    public Camera mycamera;
    public Hitstop hitstop;
    public PlayerCollisionStuff collisionStuff;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collisionStuff = GetComponent<PlayerCollisionStuff>();
        hitstop = GetComponent<Hitstop>();
        mycamera = GetComponent<Camera>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            buttonHoldTime = Time.deltaTime;
            Debug.Log("Player Key G Down");
            animator.SetBool("isPunching", true);

            if (collisionStuff.GetReadInput() == true)
            {
                Debug.Log("Player Read Input");
                hitCount = hitCount + 1;
                Debug.Log("Player Hit Count: " + hitCount);

                if (hitCount == 1)
                {
                    Debug.Log("Hit Count Condition Run");
                    CameraShake.Instance?.StartCameraShake(5, 5);
                    //hitstop.SetHitstop(2);
                }
            }
            // Looping Cycle for Array of game Objects
            //if (hitCount > 3)
            //{
            //    hitCount = 0;
            //}

        }

        if (Input.GetKeyUp(KeyCode.G) || buttonHoldTime > 20)
        {
            buttonHoldTime = 0.0f;
            animator.SetBool("isPunching", false);
        }
    }
}