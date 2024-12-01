using BlazorPokemonCardExplorer.Pages.ViewModels;
using Microsoft.AspNetCore.Components;
using ReactiveUI.Blazor;

namespace BlazorPokemonCardExplorer.Pages.Views;

public partial class Counter : ReactiveComponentBase<CounterViewModel>
{
    [Inject]
    public CounterViewModel CounterViewModel
    {
        set => ViewModel = value;
    }
}