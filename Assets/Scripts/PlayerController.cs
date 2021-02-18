using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private LayerMask platformsLayerMask;
    public Animator animator;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    
   
    

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        transform.position = position;

        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 5f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            animator.SetBool("IsJumping", true);
        }
        Debug.Log(animator.GetBool("IsJumping"));
        if(rigidbody2d.velocity.y == 0)
        {
            OnLanding();
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
}
