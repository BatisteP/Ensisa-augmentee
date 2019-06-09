using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControls : MonoBehaviour{
    public bool flag;
    public Rigidbody2D rb;
    public Transform groundCheckUp;
    public Transform groundCheckBottom;
    public Transform groundCheckRight;
    public Transform groundCheckLeft;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsDead;
    private bool leftGround;
    private bool rightGround;
    private bool upGround;
    private bool downGround;
    private bool updateOn = true;
    /* public Transform groundCheck;
 public float groundCheckRadius;
 public LayerMask whatIsGround;
 public bool onGround;*/

    void Start() {
      
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update(){
        
        if (updateOn)
        {
            rb.velocity = new Vector2(2, rb.velocity.y);
            leftGround = Physics2D.OverlapCircle(groundCheckLeft.position, groundCheckRadius, whatIsGround);
            rightGround = Physics2D.OverlapCircle(groundCheckRight.position, groundCheckRadius, whatIsGround);
            upGround = Physics2D.OverlapCircle(groundCheckUp.position, groundCheckRadius, whatIsGround);
            downGround = Physics2D.OverlapCircle(groundCheckBottom.position, groundCheckRadius, whatIsGround);

            if (Input.GetMouseButtonDown(0) && (leftGround || rightGround || upGround || downGround))
            {

                rb.velocity = new Vector2(rb.velocity.x, 5);
            }
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collison deteced");
        if (col.gameObject.tag == "ded")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (col.gameObject.tag == "pushBack")
        {
                    /*var magnitude = 2500;

            var force = transform.position - col.transform.position;

            force.Normalize();*/
            rb.AddForce(Vector2.left*4f,ForceMode2D.Impulse);
            StartCoroutine(updateOff(2f));

        }
        if (col.gameObject.tag == "BigJump")
        {
            rb.AddForce(new Vector2(0.5f,0.4f) * 30f, ForceMode2D.Impulse);
            StartCoroutine(updateOff(2f));
        }
    }
    IEnumerator updateOff(float k)
    {
        updateOn = false;
        yield return new WaitForSeconds(k);
        updateOn = true;
    }
}
