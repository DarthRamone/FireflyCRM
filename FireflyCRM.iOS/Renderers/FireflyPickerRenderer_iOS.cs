using FireflyCRM.iOS.Renderers;
using FireflyCRM.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FireflyPicker), typeof(FireflyPickerRenderer_iOS))]
namespace FireflyCRM.iOS.Renderers
{
  public class FireflyPickerRenderer_iOS : PickerRenderer
  {
    protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
    {
      base.OnElementChanged(e);
      if (e.NewElement != null)
      {
        Control.BorderStyle = UITextBorderStyle.None;
      }
    }
  }
}