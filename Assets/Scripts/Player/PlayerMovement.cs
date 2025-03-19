using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //PEGANDO COMPONENTES DO PLAYER, TAIS COMO RIGDYBODY E VECTOR 2, ALEM DE ATRIBUIR UMA VELOCIDADE.
    private Rigidbody2D rb;
    public float speed;
    private Vector2 _direction;

    //A VARIAVEL DE VELOCIDADE É PRIVADA E ELA PRECISA SER ACESSADA POR OUTRO SCRIPT (COMO O PLAYER ANIMATION), ENTÃO AQUI FOI FEITO SEU GETTER E SETTER
    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    //VARIAVEL DO RIGIDBODY RECEBE O COMPONENTE QUE ESTÁ NO PLAYER
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        OnMove();     
    }

    void Update()
    {
        GetMoveKey();
    }

    //AQUI PEGA O WASD E AS SETAS DO TECLADO, SÃO COLOCADAS EM UMA NOVA INSTANCIA DA CLASSE VECTOR2 QUE MEXE COM O X E Y DO OBJETO EM QUESTÃO
    void GetMoveKey()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    //AQUI FAZ O RIGIBODY SE MEXER
    void OnMove()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
