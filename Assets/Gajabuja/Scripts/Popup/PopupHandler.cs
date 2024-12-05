using UnityEngine;

namespace Gajabuja.Scripts.Popup
{
    public class PopupHandler : MonoBehaviour, IPopup
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private string _triggerNameOpen;
        [SerializeField] private string _triggerNameClose;
        
        
        public void Open()
        {
            _animator.SetTrigger(_triggerNameOpen);
        }

        public void Close()
        {
            _animator.SetTrigger(_triggerNameClose);
        }
    }
}
