using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PennyController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public VectorValue startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startingPosition.initialValue;
    }

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 6.0f * horizontal * Time.deltaTime;
        position.y = position.y + 6.0f * vertical * Time.deltaTime;
        transform.position = position;

        if (horizontal > 0.01f)
        {
            if (spriteRenderer.flipX == true)
            {
                spriteRenderer.flipX = false;
            }
        }
        else if (horizontal < -0.01f)
        {
            if (spriteRenderer.flipX == false)
            {
                spriteRenderer.flipX = true;
            }
        }

        animator.SetBool("grounded", true);
        animator.SetFloat("velocityX", Mathf.Abs(horizontal));
    }
}
