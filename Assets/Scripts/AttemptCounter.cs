using UnityEngine;
using UnityEngine.UI;

public class AttemptCounter : MonoBehaviour
{
    private int num = 0;

    private void Start()
    {
        num++;
        GetComponent<Text>().text = num.ToString();
    }
}
