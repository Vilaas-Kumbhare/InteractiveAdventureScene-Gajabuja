using UnityEngine;

namespace Gajabuja.Scripts.ParticlesSystem
{
    public class ParticleSystemExecute: MonoBehaviour, IParticleSystemExecute
    {
        [SerializeField] private ParticleSystem[] _particleSystems;
        
        public void Execute()
        {
            foreach (var ps in _particleSystems)
            {
                ps.Play();
            }
        }
    }
}
