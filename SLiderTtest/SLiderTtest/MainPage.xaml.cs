using Xamarin.Forms;

namespace SLiderTtest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new ViewModel();
		}
        protected override void OnBindingContextChanged()
        {
            if (BindingContext is ViewModel par)
            {
                slider.Maximum = par.Max;
                slider.SetBinding(Slider.MaximumProperty, new Binding(nameof(par.Max)));
                slider.SetBinding(Slider.MinimumProperty, new Binding(nameof(par.Min)));
                slider.SetBinding(Slider.ValueProperty, new Binding(nameof(par.Val)));
            }
            base.OnBindingContextChanged();
        }
    }
}