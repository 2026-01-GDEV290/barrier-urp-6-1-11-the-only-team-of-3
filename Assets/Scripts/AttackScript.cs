using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField] private int hitCount = 0;

    private bool readinput = false;
    private float buttonHoldTime;
    
    Animator animator;
    public Camera mycamera;
    public CameraShake mycamerashake;
    public Hitstop hitstop;
    public PlayerCollisionStuff collisionStuff;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collisionStuff = GetComponent<PlayerCollisionStuff>();
        hitstop = GetComponent<Hitstop>();
        mycamera = GetComponent<Camera>();
        mycamerashake = GetComponentInChildren<CameraShake>(true);
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
                    mycamerashake.StartCameraShake(0.2f, 0.02f);
                    //hitstop.SetHitstop(2);
                } else

                if (hitCount == 2)
                {
                    Debug.Log("Hit Count Condition Run");
                    mycamerashake.StartCameraShake(0.4f, 0.1f);
                    //hitstop.SetHitstop(2);
                } else

                if (hitCount == 3)
                {
                    Debug.Log("Hit Count Condition Run");
                    mycamerashake.StartCameraShake(0.45f, 0.55f);
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