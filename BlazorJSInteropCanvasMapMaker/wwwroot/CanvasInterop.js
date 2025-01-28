window.SetCanvas = (size) => {
    var canvas = document.getElementById("MapCanvas");
    var context = canvas.getContext("2d");
    canvas.style.width = size+"px";
    canvas.style.height = size + "px";
}