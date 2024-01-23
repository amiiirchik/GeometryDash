using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    [SerializeField] private AudioClip deathSound;
    private AudioSource levelMusic;

    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        levelMusic = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
    }

    public void DieFromSpikes()
    {
        StartCoroutine(RestartLevel());
    }

    public void DieFromPlatform()
    {
        StartCoroutine(RestartLevel());
    }

    private IEnumerator RestartLevel()
    {
        levelMusic.Stop();
        AudioSource.PlayClipAtPoint(deathSound, player.transform.position);
        
        player.SetActive(false);
        yield return new WaitForSeconds(.8f);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
