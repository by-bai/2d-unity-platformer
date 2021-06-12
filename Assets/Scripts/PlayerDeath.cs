using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerDeath : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb; 

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision) //without isTrigger
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die(); 
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static; 
        anim.SetTrigger("death"); //executes the trigger 
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
