using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mime;
using System.Reactive;
using System.Windows.Input;
using ActiproSoftware.UI.Avalonia.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Platform;
using Avalonia.Media.Imaging;
using DesignerOfLocalNet.Models;
using DynamicData;
using HarfBuzzSharp;
using Microsoft.CodeAnalysis.Scripting;
using ReactiveUI;


namespace DesignerOfLocalNet.ViewModels;

public class MainWindowViewModel : ViewModelBase {
    
    private bool _isDragging;
    private Point _startPosition;
    private double _offsetX;
    private double _offsetY;
    
    private string path = "C:/Users/sasha/RiderProjects/DesignerOfLocalNet/DesignerOfLocalNet/Assets/technology-integration.png";
    private ObservableCollection<Button> _buttons = new ObservableCollection<Button>();
    public AddButton AddButton { get; }
    public double OffsetX
    {
        get => _offsetX;
        set => this.RaiseAndSetIfChanged(ref _offsetX, value);
    }
    public double OffsetY
    {
        get => _offsetY;
        set => this.RaiseAndSetIfChanged(ref _offsetY, value);
    }
    
    public ObservableCollection<Button> Buttons
    {
        get => _buttons;
        set => this.RaiseAndSetIfChanged(ref _buttons, value);
    }
    public ReactiveCommand<Unit, Unit> CreateImageCommand
    {
        get;
    }
    // public Canvas Canvas
    // {
    //     get => _canvas;
    //     set => this.RaiseAndSetIfChanged(ref _canvas, value);
    // }
    // public Bitmap Image
    // {
    //     get => _image;
    //     set => this.RaiseAndSetIfChanged(ref _image, value);
    //
    // }
    public MainWindowViewModel()
    {
        CreateImageCommand = ReactiveCommand.Create(CreateImage);
        
        // ImageMoveCommand = ReactiveCommand.Create(ImageMove);
    }
    // public void CreateImage()
    // {
    //     Images.Add(AddImage.CreateImage());
    //     
    // }

    public void MoveCommand()
    {
        
    }
    public void CreateImage()
    {
        AddButton button = new AddButton();
        var butt = button.CreateButton();
        // butt.AddHandler(Button.ClickEvent, Button_PointerPressed);
        // Canvas.SetLeft(butt, -100 + _offsetX);
        _buttons.Add(butt);
    }
    // private void Button_PointerPressed(object sender, RoutedEventArgs e )
    // {
    //     OffsetX = 100; 
    //     OffsetY = -200;
    // }

}