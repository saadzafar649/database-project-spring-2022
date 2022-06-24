console.log("SCRIPT LOEADDE");



function showTable(table, link)
{
    document.getElementById("all").style.display = "none";
    document.getElementById("pending").style.display = "none";
    document.getElementById("delivered").style.display = "none";
    document.getElementById("cancelled").style.display = "none";
    document.getElementById("shipped").style.display = "none";

    document.getElementById("button-all").style.backgroundColor = "white";
    document.getElementById("button-pending").style.backgroundColor = "white";
    document.getElementById("button-cancelled").style.backgroundColor = "white";
    document.getElementById("button-shipped").style.backgroundColor = "white";
    document.getElementById("button-delivered").style.backgroundColor = "white";

    document.getElementById(link).style.backgroundColor = "transparent";
    document.getElementById(table).style.display = "flex";
}

document.onload = function () {
    console.log("loaded");
};
showTable("all", "button-all");