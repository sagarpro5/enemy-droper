using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 7;
    public float stopingtime = 0;
    public GameObject gameover;
    public GameObject playerobj;
    bool Isshocked = false;
    bool Ismud = false;
    bool Isoil = false;
    bool Isdead = false;


    Vector2 movementdir;
    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Isshocked && !Ismud && !Isoil) NorInput();
        if (Isshocked && !Ismud && !Isoil) shockedInput();
        if (!Isshocked && Ismud && !Isoil) mudInput();
        if (!Isshocked && !Ismud && Isoil) oilInput();
        if (Isdead) Gameover();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("sharp"))
        {
            Destroy(playerobj);
            Isdead = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "mud")
        {
            Ismud = true;
        }

        if (collision.gameObject.tag == "oil")
        {
            Isoil = true;
        }

        if (collision.gameObject.tag == "shocker")
        {
            Isshocked = true;
        }
    }

    void NorInput()
    {
        float verticalInput = Input.GetAxis("Vertical");
        movementdir = new Vector2(verticalInput, 0);
        rb2d.linearVelocity = movementdir * 4;
    }
    void shockedInput()
    {
        float random = Random.Range(1, 3);
        if(stopingtime != random)
        {
            rb2d.linearVelocity = movementdir * 0;
        }
    }
    void mudInput()
    {
        float verticalInput = Input.GetAxis("Vertical");
        movementdir = new Vector2(verticalInput, 0);
        rb2d.linearVelocity = movementdir * 2;
    }
    void oilInput()
    {
        float verticalInput = Input.GetAxis("Vertical");
        movementdir = new Vector2(verticalInput, 0);
        rb2d.linearVelocity = movementdir * 6;
    }

    public void left()
    {
        float random = Random.Range(1, 3);
        if (!Ismud && !Isoil)
        {
            if (stopingtime != random)
            {
                rb2d.AddForce(Vector2.left * speed * 4, ForceMode2D.Force);
            }
        }
        if (Ismud && !Isoil)
        {
            if (stopingtime != random)
            {
                rb2d.AddForce(Vector2.left * speed * 2, ForceMode2D.Force);
            }
        }
        if (!Ismud && Isoil)
        {
            if (stopingtime != random)
            {
                rb2d.AddForce(Vector2.left * speed * 6, ForceMode2D.Force);
            }
        }
    }
    public void right()
    {
        float random = Random.Range(1, 3);
        if (!Ismud && !Isoil)
        {
            if (stopingtime != random)
            {
                rb2d.AddForce(-Vector2.left * speed * 4, ForceMode2D.Force);
            }
        }
        if (Ismud && !Isoil)
        {
            if (stopingtime != random)
            {
                rb2d.AddForce(-Vector2.left * speed * 2, ForceMode2D.Force);
            }
        }
        if (!Ismud && Isoil)
        {
            if (stopingtime != random)
            {
                rb2d.AddForce(-Vector2.left * speed * 6, ForceMode2D.Force);
            }
        }
    }

    public void Gameover()
    {
        gameover.SetActive(true);
    }

}
