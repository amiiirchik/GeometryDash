using UnityEngine;

public class Task3_1 : MonoBehaviour
{
    [SerializeField] int targetRoomId = 2;                                     //Значение 2 по умолчанию

    private void Start()
    {
        Debug.Log("Добро пожаловать!");

        for (int i = 0; i < 4; i++)                                            //Комнаты
        {
            if (i == targetRoomId)
            {
                Debug.Log($"Вы нашли нужную комнату. Номер комнаты: {i}");
                //break;
                return;                                                        //Выход из цикла 
            }

            Debug.Log($"Вы вошли в комнату {i}.");

            for (int j = 0; j < 4; j++)                                        //Углы
            {
                Debug.Log($"Вы решили осмотреть угол. Номер угла: {j}");
            }
        }

        Debug.Log("Ура! Победа!");
    }
}
