using System.Collections;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject finishCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FinishAndCloseGame());
        }
    }

    private IEnumerator FinishAndCloseGame()
    {
        finishCanvas.SetActive(true);
        yield return new WaitForSeconds(3f);
        Application.Quit();
    }
}
