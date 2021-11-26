using CommonBasicLibraries.CollectionClasses;
namespace Reminders.BlazorCoreLibrary.Components;
public partial class ReminderListComponent<T>
{
    [Parameter]
    public BasicList<T> ItemList { get; set; } = new();
}