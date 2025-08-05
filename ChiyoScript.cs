using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChiyoScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    public SpriteRenderer spriteRenderer;

    public Sprite[] sprites = new Sprite[2];
    private bool isSpriteFalling = true;

    public LogicScript logic;

    public int points = 0;
    public Text text;

    public AudioSource satandagi;
    public AudioSource scream;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isAlive) return;

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0)))
        {
            rigidbody.linearVelocity = Vector2.up * 9;

            spriteRenderer.sprite = sprites[1];
            isSpriteFalling = false;
        }
        else if (!isSpriteFalling && rigidbody.linearVelocity.y < 1)
        {   
            spriteRenderer.sprite = sprites[0];
            isSpriteFalling = true;
        }

        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Chili") {
            logic.death();
            return;
        }

        points++;
        text.text = points.ToString();

        Destroy(other.gameObject);
        satandagi.Play();
    }

    void OnBecameInvisible()
    {
        if (!logic.isAlive)
        {
            Destroy(gameObject);
            return;
        }

        transform.SetPositionAndRotation(new Vector3(transform.position.x, -transform.position.y), transform.rotation);
    }
}
