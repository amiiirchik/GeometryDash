using UnityEngine;

public class Task3 : MonoBehaviour
{
    private void Start()
    {
        for(int i = 1; i < 5; i++)
        {
            Debug.Log("�������� �����: " + i);
            //(i == 4) ? Debug.Log($"���� ���������� {i} ���") : "";
            if (i == 4)
                Debug.Log($"���� ���������� {i} ���(-�)");
        }
    }
}
