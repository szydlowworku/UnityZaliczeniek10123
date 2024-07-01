using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Death : MonoBehaviour
{
     private Rigidbody2D rb;
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        if (rb.IsTouchingLayers(LayerMask.GetMask("Spikes")) || rb.transform.position.y < -10 || rb.IsTouchingLayers(LayerMask.GetMask("Enemy")))
        {
            Die();
            Restart();
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Die()
    {   
        Destroy(rb);
        Destroy(renderer);
    }
}
