using UnityEngine;

public class AnimattionController : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public float minTime = 5f;
    public float maxTime = 15f;
    public float timer;
    public bool Moving;
    private Move Move;


    void Start()
    {
        Move = player.GetComponent<Move>();
        ResetTimer();
    }

    void Update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        // boredanim
        if (stateInfo.IsName("Idle"))
        {
            timer -= Time.deltaTime;
            if (timer <= 0f) {
                animator.SetTrigger("GetBored");
                ResetTimer();
            }
        } else ResetTimer();

        // move
        if (Move.movement.x != 0 || Move.movement.y != 0) Moving = true;
        else Moving = false;

        animator.SetBool("Running", Moving);
        if (Move.movement.x< 0) player.transform.eulerAngles = new Vector3(0f, 180f, 0f);
        else player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

    void ResetTimer()
    {
        timer = Random.Range(minTime, maxTime);
    }
}



