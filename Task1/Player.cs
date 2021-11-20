using System;

namespace Napilnik.Task1
{
    public class Player
    {
        private int _health;

        public Player(int health)
        {
            if (health < 1)
                throw new ArgumentOutOfRangeException(nameof(health));

            _health = health;
        }

        private bool IsDead => _health == 0;

        public void TakeDamage(int damage)
        {
            if (IsDead)
                throw new InvalidOperationException();
            
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));
            
            _health = Math.Clamp(_health - damage, 0, int.MaxValue);
        }
    }
}