using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media.Imaging;
using DesignerOfLocalNet.Views;

namespace DesignerOfLocalNet.Models;

public class AddButton 
{
    private bool _isDragging;
    private Point _startPosition;
    public Button CreateButton()
    {
        Button button = new Button();
        Image image = new Image();
        image.Source = new Bitmap("C:/Users/sasha/RiderProjects/DesignerOfLocalNet/DesignerOfLocalNet/Assets/technology-integration.png");
        
        image.Height = 50;
        image.Width = 50;
        button.Content = image;
        button.Width = 50;
        button.Height = 50;
        
        return button;
    }
}