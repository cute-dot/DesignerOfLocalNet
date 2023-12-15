using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.PanAndZoom;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DesignerOfLocalNet.ViewModels;

namespace DesignerOfLocalNet.Views;

public partial class MainWindow : Window
{
    private readonly ZoomBorder? _zoomBorder;
    
    public MainWindow()
    {
        this.InitializeComponent();
        DataContext = new MainWindowViewModel();
        _zoomBorder = this.Find<ZoomBorder>("ZoomBorder");
        if (_zoomBorder != null)
        {
            _zoomBorder.KeyDown += ZoomBorder_key;
        }
        
    }

    private void ZoomBorder_key(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.R)
        {
            _zoomBorder?.ResetMatrix();
        }
    }

    
}
