using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] string neededItem;

    [ContextMenu("Find")]
    private void FindItem()
    {
        string[] inventory = { "меч", "дубинка", "дубинка", "дубинка", "камень", "камень" };

        int itemCount = 0;

        foreach(string item in inventory)
        {
            if (item == neededItem.ToLower())
                itemCount++;
        }

        Debug.Log($"Кол-во предмета '{neededItem}': {itemCount}");
    }
}
