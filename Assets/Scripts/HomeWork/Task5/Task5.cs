using UnityEngine;
using Battle.Actors;
using Battle.Abilities;

public class Task5 : MonoBehaviour
{
    private void Start()
    {
        Actor player = new Actor("����", 100, 30,
            new IAbility[] {
                new DamageBuff(3, "������ �������"), new HpBuff(10, "���������") });

        Actor[] enemies = {
            new Actor("������", 30, 10, new IAbility[] { new DamageBuff(5, "����") }),
            new Actor("����", 40, 20) };

        for (int turns = 1; turns < 5; turns++)
        {
            bool isPlayerDead = false;
            bool isAllEnemiesDead = true;

            foreach (Actor enemy in enemies)
            {
                if (enemy.isDead())
                    continue;

                enemy.UseAbility();
                isPlayerDead = Attack(enemy, player);

                if (isPlayerDead)
                    break;

                player.UseAbility();

                var isEnemyDead = Attack(player, enemy);
                isAllEnemiesDead = isAllEnemiesDead && isEnemyDead;
            }

            if (isPlayerDead || isAllEnemiesDead)
                break;
        }
    }

    private bool Attack(Actor attacker, Actor defender)   //���������� ���� �� ������������
    {
        defender.TakeDamage(attacker);
        defender.PrintStatus();

        return defender.isDead();
    }
}
