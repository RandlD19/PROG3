using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int i = 0;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Gumb_klik(object sender, EventArgs e)
    {
        i++;
        this.button6.Label = $"Število klikov {i}";
    }
}
