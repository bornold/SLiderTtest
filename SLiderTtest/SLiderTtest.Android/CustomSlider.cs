using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using SLiderTtest.Droid;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(Slider), target: typeof(CustomSlider))]
namespace SLiderTtest.Droid
{
    public class CustomSlider : SliderRenderer
    {
        public CustomSlider(Context context) : base(context) { }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}