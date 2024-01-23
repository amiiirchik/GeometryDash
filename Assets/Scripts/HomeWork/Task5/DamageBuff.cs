using Battle.Actors;

namespace Battle.Abilities
{
    public class DamageBuff : IAbility
    {
        private string AbilityName;
        private int DamageBuffValue;

        public DamageBuff(int damageBuffValue, string abilityName)
        {
            DamageBuffValue = damageBuffValue;
            AbilityName = abilityName;
        }

        public override void Use(Actor target)
        {
            target.Damage += DamageBuffValue;
            target.Print($"����������� '{AbilityName}' � �������� ���� ���� ��������: {DamageBuffValue}");
        }
    }
}


