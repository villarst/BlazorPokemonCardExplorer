using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace BlazorPokemonCardExplorer.Pages.ViewModels;

public class CounterViewModel : ReactiveObject
{

    [Reactive] public int CurrentCount { get; set; } = 0;

    public void IncrementCount()
    {
        CurrentCount++;
    }
    
    public void ResetCount()
    {
        CurrentCount = 0;
    }
    
    public void DecrementCount()
    {
        CurrentCount--;
    }
}