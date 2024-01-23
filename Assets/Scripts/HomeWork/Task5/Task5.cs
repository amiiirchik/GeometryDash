using UnityEngine;
using Battle.Actors;
using Battle.Abilities;

public class Task5 : MonoBehaviour
{
    private void Start()
    {
        Actor player = new Actor("Иван", 100, 30,
            new IAbility[] {
                new DamageBuff(3, "Ярость самурая"), new HpBuff(10, "Исцеление") });

        Actor[] enemies = {
            new Actor("Собака", 30, 10, new IAbility[] { new DamageBuff(5, "Гнев") }),
            new Actor("Волк", 40, 20) };

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

    private bool Attack(Actor attacker, Actor defender)   //Возвращает умер ли защищающийся
    {
        defender.TakeDamage(attacker);
        defender.PrintStatus();

        return defender.isDead();
    }
}
