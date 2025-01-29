using BlazorJSInteropCanvasMapMaker.Interfaces.DropDownServices;

namespace BlazorJSInteropCanvasMapMaker.Services.DropDownServices
{
    public class DropDownStringOptionsService : IDropDownStringOptionsService
    {
        public IEnumerable<string> Options => new List<string>() {
            "None",
            "DarkGreen",
            "DarkKhaki",
            "DarkOliveGreen",
            "DarkSeaGreen",
            "Beige",
            "Bisque",
            "BurlyWood",
        };
    }
}
