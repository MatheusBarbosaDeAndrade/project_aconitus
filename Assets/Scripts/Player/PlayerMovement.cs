using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private Vector2 _direction;

    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

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

    void GetMoveKey()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void OnMove()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
