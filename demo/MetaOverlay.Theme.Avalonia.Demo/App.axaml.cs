using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MetaOverlay.Theme.Avalonia.Demo.ViewModels;
using MainView = MetaOverlay.Theme.Avalonia.Demo.Views.MainView;
using MainWindow = MetaOverlay.Theme.Avalonia.Demo.Views.MainWindow;

namespace MetaOverlay.Theme.Avalonia.Demo;

using MainView = Views.MainView;
using MainWindow = Views.MainWindow;

public class App : Application {
    public override void Initialize() { AvaloniaXamlLoader.Load(this); }

    public override void OnFrameworkInitializationCompleted() {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            desktop.MainWindow = new MainWindow { DataContext = new MainViewModel() };
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
            singleViewPlatform.MainView = new MainView { DataContext = new MainViewModel() };

        base.OnFrameworkInitializationCompleted();
    }
}