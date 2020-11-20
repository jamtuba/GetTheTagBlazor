using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System.Collections.Generic;

namespace GetTheTagBlazor.Shared.ModelsDTO
{
    public class TagDTO
    {
        public ImageCaption Caption { get; set; }
        public List<Category> Categories { get; set; }
        public List<ImageTag> Tags { get; set; }

        public TagDTO(ImageCaption caption, List<Category> categories, List<ImageTag> tags)
        {
            Caption = caption;
            Categories = categories;
            Tags = tags;
        }

        public TagDTO(){}
    }
}
