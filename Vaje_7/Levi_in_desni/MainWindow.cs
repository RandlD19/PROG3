using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void LeviPritisnjen(object sender, EventArgs e)
    {
        this.label2.Text = "<- pritisnjen";
    }

    protected void DesniPritinjen(object sender, EventArgs e)
    {
        this.label2.Text = "pritisnjen ->";
    }

    protected void LeviSpuscen(object sender, EventArgs e)
    {
        this.label2.Text = "";
    }

    protected void DesniSpuscen(object sender, EventArgs e)
    {
        this.label2.Text = "";
    }
}
