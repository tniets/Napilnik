using System;

namespace Napilnik.Task1
{
    public class Weapon
    {
        private readonly int _damage;
        private readonly int _bulletsPerShot;
        private int _bullets;

        public Weapon(int damage, int bullets, int bulletsPerShot = 1)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            if (bulletsPerShot < 1)
                throw new ArgumentOutOfRangeException(nameof(bulletsPerShot));

            _damage = damage;
            _bullets = bullets;
            _bulletsPerShot = bulletsPerShot;
        }

        private bool NotEnoughBullets => _bullets < _bulletsPerShot;

        public void Fire(Player player)
        {
            if (player == null)
                throw new NullReferenceException(nameof(player));
            
            if (NotEnoughBullets)
                throw new InvalidOperationException(nameof(NotEnoughBullets));
            
            player.TakeDamage(_damage);
            _bullets -= _bulletsPerShot;
        }
    }
}