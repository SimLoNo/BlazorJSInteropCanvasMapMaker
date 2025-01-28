namespace BlazorJSInteropCanvasMapMaker.Models
{
    public class MapModel
    {
        public string? Name { get; set; }
        public int Size { get; set; }

        List<MapEntity> Entities { get; set; } = [];
    }
}
