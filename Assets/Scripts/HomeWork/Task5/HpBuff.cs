using Battle.Actors;

namespace Battle.Abilities
{
    public class HpBuff : IAbility
    {
        private string AbilityName;
        private int HealthBuffValue;

        public HpBuff(int healthBuffValue, string abilityName)
        {
            HealthBuffValue = healthBuffValue;
            AbilityName = abilityName; 
        }

        public override void Use(Actor target)
        {
            target.Health += HealthBuffValue;
            target.Print($"Использовал '{AbilityName}' и получил бафф к здоровью: {HealthBuffValue}, текущее здоровье: {target.Health}");
        }
    }
}


