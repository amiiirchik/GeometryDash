using UnityEngine;

public class Task3_1 : MonoBehaviour
{
    [SerializeField] int targetRoomId = 2;                                     //�������� 2 �� ���������

    private void Start()
    {
        Debug.Log("����� ����������!");

        for (int i = 0; i < 4; i++)                                            //�������
        {
            if (i == targetRoomId)
            {
                Debug.Log($"�� ����� ������ �������. ����� �������: {i}");
                //break;
                return;                                                        //����� �� ����� 
            }

            Debug.Log($"�� ����� � ������� {i}.");

            for (int j = 0; j < 4; j++)                                        //����
            {
                Debug.Log($"�� ������ ��������� ����. ����� ����: {j}");
            }
        }

        Debug.Log("���! ������!");
    }
}
