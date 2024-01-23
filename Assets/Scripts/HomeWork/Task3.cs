using UnityEngine;

public class Task3 : MonoBehaviour
{
    private void Start()
    {
        for(int i = 1; i < 5; i++)
        {
            Debug.Log("Итерация цикла: " + i);
            //(i == 4) ? Debug.Log($"Цикл выполнился {i} раз") : "";
            if (i == 4)
                Debug.Log($"Цикл выполнился {i} раз(-а)");
        }
    }
}
