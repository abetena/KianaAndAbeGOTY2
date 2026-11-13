using Playground.Movement;
using UnityEngine;

public class ChangeJumpS : MonoBehaviour
{

    public float newJumpStrength = 20f;

     private Jump jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Powerup"))
        {
            jump.jumpStrength = newJumpStrength;
            Destroy(collision.gameObject);
        }
    }
}
