using UnityEngine;
using Battle.Abilities;

namespace Battle.Actors
{
    public class Actor
    {
        private IAbility[] Abilities;

        private string Name;
        public int Health;                     //���. ������� ��� ����� � �������� � ������-������� � ������ HpBuff
        public int Damage;                    //���. ������� ��� ����� � ����� � ������-������� � ������ DamageBuff
        private int MaxHealth;

        public Actor(string name, int health, int damage, IAbility[] abilities = null)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Abilities = abilities;

            Initialize();
        }

        private void Initialize()
        {
            MaxHealth = Health;
        }

        public void TakeDamage(Actor attacker)
        {
            Health -= attacker.Damage;
            Print($"��� �������� {attacker.Name}");
        }

        public void PrintStatus()
        {
            if (isDead())
                Print("����");
            else
                Print($"{Health}/{MaxHealth}");
        }

        public virtual void UseAbility()
        {
            if (Abilities == null)
                return;

            foreach (IAbility ability in Abilities)
            {
                ability.Use(this);
            }
        }

        public bool isDead()
        {
            return Health <= 0;
        }

        public void Print(string msg)
        {
            Debug.Log($"{Name} {msg}");
        }
    }
}