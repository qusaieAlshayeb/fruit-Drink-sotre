using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;

namespace fruitDrink.TagHelpers
{
    public class EmailTagHelper:TagHelper
    {
  
        public string Address { get; set; }  //this for sent email address to contact us

        public string content { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" +Address);
            output.Content.SetContent(content);
        }

    }
}
