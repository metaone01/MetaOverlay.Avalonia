using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace MetaOverlay.Theme.Avalonia.Demo.Views;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        WindowState = WindowState.Maximized;
        PointerExited += (_, _) => { Close(); };
    }
}