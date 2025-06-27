using UnityEngine;

public class AnimattionController : MonoBehaviour
{
    public Animator animator;

    public float minTime = 5f; 
    public float maxTime = 15f; 
    private float timer;

    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("Idle"))
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                animator.SetTrigger("Bored");
                ResetTimer(); 
            }
        }
        else ResetTimer();
    }

    void ResetTimer()
    {
        timer = Random.Range(minTime, maxTime);
    }
}

