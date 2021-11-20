using System;

namespace Napilnik.Task1
{
    public class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            _weapon = weapon ?? throw new NullReferenceException(nameof(weapon));
        }

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}