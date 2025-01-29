window.SetCanvas = (size, terrainColour) => {

    const canvasColumn = document.getElementById("CanvasColumn");
    var canvas = document.getElementById("MapCanvas"); // 
    if (canvas === null)
    {
        canvas = document.createElement("Canvas");
        canvas.id = "MapCanvas";
        canvasColumn.appendChild(canvas);
    }
    const context = canvas.getContext("2d");
    canvas.style.width = size+"px";
    canvas.style.height = size + "px";
    context.clearRect(0, 0, canvas.width, canvas.height);
    canvas.style.border = "5px solid black";
    if (terrainColour != "" && terrainColour != "None") {
        context.fillStyle = terrainColour;
        context.fillRect(0,0,size,size);
    }

}