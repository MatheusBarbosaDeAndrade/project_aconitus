using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //PEGANDO O COMPONENTE ANIMATOR QUE ESTÁ NO PLAYER E TAMBÉM O SCRIPT PLAYERMOVEMENT
    private Animator animator;
    private PlayerMovement playerMov;
    void Start()
    {
        //COLOCANDO OS COMPONENTES NAS VARIAVEIS DECLARADAS ANTERIORMENTE
        animator = GetComponent<Animator>();
        playerMov = GetComponent<PlayerMovement>();
    }

    
    void Update()
    {
        FlipSprite();
        TransitionWalking();
    }

    //TRANSIÇÃO DO PERSONAGEM PARA ANDANDO CASO A SOMA DOS QUADRADOS DO X E Y DO (CONTA ESSA QUE É FEITA PELO SQRMAQNITUDE) JOGADOR SEJA MAIOR QUE 0
    void TransitionWalking()
    {
        if (playerMov.direction.sqrMagnitude > 0)
        {
            if (playerMov.direction.y > 0)
            {
                animator.SetInteger("transition", 2);
            }
            else if(playerMov)
            {
                animator.SetInteger("transition", 1);
            }
        }
        else
        {
            animator.SetInteger("transition", 0);
        }
    }

    //FLIPANDO O SPRITE DO PERSONAGEM DE ACORDO COM A DIREÇÃO DO EIXO X EM QUE ELE ESTIVER SE DIRIGINDO
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
