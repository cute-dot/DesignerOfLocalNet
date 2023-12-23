using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.PanAndZoom;
using Avalonia.Controls.Templates;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using DesignerOfLocalNet.Models;
using DesignerOfLocalNet.ViewModels;

namespace DesignerOfLocalNet.Views;

public partial class MainWindow : Window
{
    private readonly ZoomBorder? _zoomBorder;
    
    public interface IControl
    {
        
    }
    
    public MainWindow()
    {
        this.InitializeComponent();
        // Map map = new Map(ref canvas);
        DataContext = new MainWindowViewModel();
        _zoomBorder = this.Find<ZoomBorder>("ZoomBorder");
        if (_zoomBorder != null)
        {
            _zoomBorder.KeyDown += ZoomBorder_key;
        }
        
        // CreateImage();
    }
    
    private void ZoomBorder_key(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.R)
        {
            _zoomBorder?.ResetMatrix();
        }
        
    }
    
    
    // public void CreateImage()
    // {
    //     Image kol = new Image();
    //     kol.Source = new Bitmap("C:/Users/sasha/RiderProjects/DesignerOfLocalNet/DesignerOfLocalNet/Assets/Commutator.png");
    //     kol.Width = 50;
    //     kol.Height = 50;
    //     kol.ZIndex = 1;
    //     Holst.Children.Add(kol);
    // }
}
