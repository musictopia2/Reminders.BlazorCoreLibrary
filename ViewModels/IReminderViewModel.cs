namespace Reminders.BlazorCoreLibrary.ViewModels;
public interface IReminderViewModel
{
    string NextDayText { get; set; }
    string CurrentDateText { get; set; }
}