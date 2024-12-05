namespace Gajabuja.Scripts.Interactables
{
    public interface IInteractable
    {
        public void Register(IinteractionLogger interactor);
        public void Remove(IinteractionLogger interactor);
        public void Interact();
    }
}
