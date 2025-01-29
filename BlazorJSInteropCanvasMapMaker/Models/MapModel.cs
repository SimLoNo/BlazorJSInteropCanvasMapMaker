using BlazorJSInteropCanvasMapMaker.Enums;

namespace BlazorJSInteropCanvasMapMaker.Models
{
    public class MapModel
    {
        public string? Name { get; set; }
        public int Size { get; set; }
        public string BaseTerrainColour { get; set; } = "None";

        List<MapEntity> Entities { get; set; } = [];
    }
}
