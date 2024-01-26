using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    [SerializeField] private float timeBeforeRestart;

    [SerializeField] private AudioClip deathSound;
    [SerializeField] private GameObject deathEffect;
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
        Instantiate(deathEffect, player.transform.position, player.transform.rotation);
        yield return new WaitForSeconds(timeBeforeRestart);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
