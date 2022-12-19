using UD5T2.ViewModels;

namespace UD5T2;

public partial class BMIView : ContentPage
{
    /// <summary>
    /// BINDEA EL VIEWMODEL CON LOS RESULTADOS QUE DEMOS
    /// </summary>
    public BMIView()
    {
        InitializeComponent();

        BindingContext = new BMIViewModel();
    }
}