using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Interactivity;
using System;

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
{
    InitializeComponent();   // aquí se carga el XAML
 
    // Lo que escribas a partir de aquí se ejecuta después de cargar el XAML
    Title = "Título cambiado desde C#";
    saludo.Text = "Este texto lo ha puesto el C#";
    saludo.Foreground = Brushes.Crimson;
    var extra = new Button
    
    {
        Content = "Botón creado en C#",
        Margin = new Thickness(0, 10, 0, 0)
    };
    extra.Click += AbrirVentanaCS;
    boton.Click += Boton_Click;
    panel.Children.Insert(0, extra);
}

    private void AbrirVentanaCS(object? sender, RoutedEventArgs e)
    {
        var ventana = new VentanaCS();
        ventana.Show();
    }

    private void Boton_Click(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "¡Has pulsado el botón!";
    }
}