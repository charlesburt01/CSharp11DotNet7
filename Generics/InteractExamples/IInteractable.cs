public interface IInteractable
{
    void OnInteracted<T>(T interactor) where T : IInteractor<IInteractable>;
}
