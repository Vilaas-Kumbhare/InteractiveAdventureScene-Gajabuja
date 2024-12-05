using UnityEngine;

namespace Gajabuja.Scripts.AudioManager
{
    public class AudioManager: MonoBehaviour
    {
        [SerializeField] private AudioSource[] audioSources;

        public void ToggleSound(bool isEnabled)
        {
            foreach (var source in audioSources)
            {
                source.mute = !isEnabled;
            }
        }
    }
}
