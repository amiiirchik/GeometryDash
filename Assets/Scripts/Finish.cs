using UnityEngine;

public class Finish : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //anim.SetBool("Finished", true);
            Debug.Log("Finished");
        }
    }
}
