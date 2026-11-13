using Playground.Movement;
using UnityEngine;

public class jumpPowerUp : MonoBehaviour
{

public float newJumpStrength = 20f;

    void OnTrigger2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
                Debug.Log("Player picked up jump power-up");
                collision.gameObject.GetComponent<Jump>().jumpStrength = newJumpStrength;
                Destroy(gameObject);
        }
    }
}
