using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerDeathHandler DeathHandler;
    [SerializeField] private LayerMask layerMask;

    private void Update()
    {
        RaycastHit2D rayTop = Physics2D.Raycast(transform.position - new Vector3(0.52f, 0.2f, 0), Vector2.right, 1.04f, layerMask);
        RaycastHit2D rayBottom = Physics2D.Raycast(transform.position - new Vector3(0.52f, -0.2f, 0), Vector2.right, 1.04f, layerMask);

        if (rayTop.collider != null || rayBottom.collider != null)
        {
            DeathHandler.DieFromPlatform();
        }

        Debug.DrawRay(transform.position - new Vector3(0.52f, 0.2f, 0), Vector2.right * 1.04f, Color.red);
        Debug.DrawRay(transform.position - new Vector3(0.52f, -0.2f, 0), Vector2.right * 1.04f, Color.red);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly"))
        {
            DeathHandler.DieFromSpikes();
        }
    }
}