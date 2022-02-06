function displayImage(clickedThumbnail) {
    document.getElementById("preview").src = clickedThumbnail.src;

    removeBordersFromAllThumbnails();

    clickedThumbnail.style.border = "5px solid var(--aqua-blue)";
}

function removeBordersFromAllThumbnails() {
    const thumbnailsDiv = document.getElementById("thumbnails");
    const thumbnails = thumbnailsDiv.getElementsByTagName("img");
    for (const thumbnail of thumbnails) {
        thumbnail.style.border = "unset";
    }
}