using System;
using Avalonia.Controls;

namespace DesignerOfLocalNet.Models;

public class Map
{   
    private Canvas _canvas;

    public Canvas Canvas
    {
        get => _canvas;
        set => _canvas = value ?? throw new ArgumentNullException(nameof(value));
    }
    public Map(Canvas canvas)
    {
        _canvas = canvas;
    }
}