using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HolaAvalonia;

public class VentanaCS : Window
{
    // Campo para poder utilizar el saludo desde otros métodos
    private TextBlock saludo = null!;

    public VentanaCS()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Title = "Título cambiado desde C#";
        Width = 800;
        Height = 450;

        saludo = new TextBlock
        {
            Text = "Este texto lo ha puesto el C#",
            FontSize = 24,
            Foreground = Brushes.Crimson
        };

        var boton2 = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };

        var boton = new Button
        {
            Content = "Púlsame",
            Margin = new Thickness(0, 10, 0, 0)
        };

        

        boton.Click += Boton_Click;
        var panel = new StackPanel
        {
            Margin = new Thickness(20)
        };

        panel.Children.Add(saludo);
        panel.Children.Add(boton2);
        panel.Children.Add(boton);

        Content = panel;
    }

    private void Boton_Click(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "¡Has pulsado el botón!";
    }
}