using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Akar.Portfolio.WebUI.Extentions.TagHelpers.ProfilCardImageTagHelper
{
    [HtmlTargetElement("card-image")]
    public class CardImage : TagHelper
    {
        [HtmlAttributeName("image-path")]
        public string ImagePath { get; set; }



        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //if (File.Exists(ImagePath))
            //{
            //    // Image dosyası mevcutsa img etiketi oluştur
            //    output.TagName = "img";
            //    output.Attributes.SetAttribute("src", ImagePath);
            //    output.TagMode = TagMode.SelfClosing;
            //}
            //else
            //{
            //    // Image dosyası yoksa, fallback metni oluştur
            //    output.TagName = "span";
            //    output.Content.SetContent(FallbackText);
            //}


            base.Process(context, output);
        }

    }
}
