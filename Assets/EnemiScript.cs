using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 2f; // Speed of the enemy
    public float distance = 5f; // Distance the enemy moves before turning around

    private bool movingRight = true;
    private float moveDirection = 1f;
    private float startX;

    void Start()
    {
        startX = transform.position.x; // Store the starting X position
    }

    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        // Move the enemy
        transform.Translate(Vector2.right * speed * moveDirection * Time.deltaTime);

        // Check if the enemy has moved the specified distance
        if (Mathf.Abs(transform.position.x - startX) >= distance)
        {
            // Reverse direction
            moveDirection *= -1;
            startX = transform.position.x; // Update the starting position
        }
    }
}