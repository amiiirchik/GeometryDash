using UnityEngine;

public class Task2 : MonoBehaviour
{
    private void Start()
    {
        int _health = 100;
        int _damage = 40;
        int _heal = 20;

        _health -= _damage;
        Debug.Log("Damage: " + _damage + " | Current health: " + _health);

        _health += _heal;
        Debug.Log("Healed: " + _heal + " | Current health: " + _health);
    }
}
