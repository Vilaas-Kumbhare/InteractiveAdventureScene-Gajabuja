using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gajabuja.Scripts.Interactables
{
    public class InteractableObject :MonoBehaviour, IInteractable
    {
        [SerializeField] private UnityEvent _action;
        
        private List<IinteractionLogger> _interactionLoggers = new List<IinteractionLogger>();

        public void Register(IinteractionLogger interactionLogger)
        {
            _interactionLoggers.Add(interactionLogger);
        }

        public void Remove(IinteractionLogger interactionLogger)
        {
            _interactionLoggers.Remove(interactionLogger);
        }

        public void Interact()
        {
            _action?.Invoke();
        }

        private void OnMouseDown()
        {
            if (_interactionLoggers == null || _interactionLoggers.Count == 0)
                return;

            for (int i = _interactionLoggers.Count - 1; i >= 0; i--)
            {
                _interactionLoggers[i]?.UpdateLogger();
            }

            Interact();
        }
    }
}
