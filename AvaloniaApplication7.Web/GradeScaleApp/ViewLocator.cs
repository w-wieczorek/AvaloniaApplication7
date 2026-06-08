using Avalonia.Controls;
using Avalonia.Controls.Templates;
using GradeScaleApp.ViewModels;
using GradeScaleApp.Views;

namespace GradeScaleApp;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is MainViewModel)
        {
            return new MainView();
        }

        return new TextBlock { Text = "Not Found: " + param?.GetType().FullName };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}