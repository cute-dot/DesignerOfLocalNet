
using System;
using System.Reactive;
using System.Windows.Input;
using ActiproSoftware.UI.Avalonia.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Platform;
using Avalonia.Media.Imaging;
using ReactiveUI;


namespace DesignerOfLocalNet.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private Bitmap _image;

    public ReactiveCommand<Unit, Unit> CreateImageCommand
    {
        get;
    }

    public Bitmap Image
    {
        get => _image;
        set => this.RaiseAndSetIfChanged(ref _image, value);

    }
    public MainWindowViewModel()
    {
        CreateImageCommand = ReactiveCommand.Create(CreateImage);
    }

    public void CreateImage()
    {
        Image = new Bitmap("Assets/technology-integration.png");
        
        
    }
}