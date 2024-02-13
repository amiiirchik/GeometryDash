using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    private Button button;

    [SerializeField] private PlayerMovement Player;

    private void Start()
    {
        button = GetComponent<Button>();
    }

    public void Pause()
    {
        Time.timeScale = 0f;

        button.onClick.AddListener(Unpause);
    }

    private void Unpause()
    {
        Time.timeScale = 1f;

        button.onClick.AddListener(Pause);
    }
}
