public interface IInteractor<T> where T : IInteractable
{
    void Interact(T interactable);
}

