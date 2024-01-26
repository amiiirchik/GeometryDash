using UnityEngine;
using UnityEngine.UI;

public class DontDestroyOnLoad : MonoBehaviour
{
    private Text attemptText;

    private int attemptCount = 1;

    private void Start()
    {
        attemptText = GetComponent<Text>();
        int savedAttemptValue = PlayerPrefs.GetInt("Attempts");

        if (savedAttemptValue != 0)
        {
            attemptText.text = savedAttemptValue.ToString();
            PlayerPrefs.SetInt("Attempts", savedAttemptValue + 1);
        }
        else
        {
            attemptText.text = attemptCount.ToString();
            PlayerPrefs.SetInt("Attempts", attemptCount + 1);
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}