using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100f;
        [SerializeField] GameObject deathVFX;
        public void DealDamage(float damage)
        {
            health -= damage;
            if (health <= 0)
            {
                TriggerDeathVFX();
                Destroy(gameObject);

            }
        }

        private void TriggerDeathVFX()
        {
            if (!deathVFX) return;
            var deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
            Destroy(deathVFXObject, 1f);
        }
    }
}
