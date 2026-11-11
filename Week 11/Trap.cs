using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private SpriteRenderer[] sprites;

    private void Awake()
    {
        sprites = GetComponentsInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        foreach (SpriteRenderer sprite in sprites)
        {
            sprite.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (SpriteRenderer sprite in sprites)
            {
                sprite.enabled = true;
            }

            playerHealth.health -= 10;
        }
    }
}
