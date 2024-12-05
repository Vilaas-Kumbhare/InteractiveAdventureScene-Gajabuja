using UnityEngine;
using UnityEngine.Events;

namespace Gajabuja.Scripts.Interactables
{
    public class InteractionLogger: MonoBehaviour, IinteractionLogger
    {
        [SerializeField] private InteractableObject[] _interactable;

        [SerializeField] private UnityEvent _event;

        private void Start()
        {
            Register();
        }

        public void UpdateLogger()
        {
            _event?.Invoke();
        }

        private void OnDestroy()
        {
            DeRegister();
        }



        private void Register()
        {
            foreach (var obj in _interactable)
            {
                obj.Register(this);
            }
        }

        private void DeRegister()
        {
            foreach (var obj in _interactable)
            {
                obj.Remove(this);
            }
        }
    }
}
