using System;
using UnityEngine;
using UnityEngine.UI;

public class AttemptCounter : MonoBehaviour
{
    [SerializeField] private Text attemptsCounter;
    [SerializeField] private Canvas canvas;
    private int attempts;

    private void Awake()
    {
        attemptsCounter.text = Convert.ToString(attempts);
    }

    private void OnDisable()
    {
        attempts++;
        attemptsCounter.text = Convert.ToString(attempts);
    }
}
