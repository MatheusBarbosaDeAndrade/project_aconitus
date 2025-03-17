using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement playerMov;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerMov = GetComponent<PlayerMovement>();
    }

    
    void Update()
    {
        FlipSprite();
        TransitionWalking();
    }

    void TransitionWalking()
    {
        if (playerMov.direction.sqrMagnitude > 0)
        {
            animator.SetInteger("transition", 1);
        }
        else
        {
            animator.SetInteger("transition", 0);
        }
    }


    #region FlipSprite
    void FlipSprite()
    {
        if(playerMov.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if(playerMov.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
    }
    #endregion
}
