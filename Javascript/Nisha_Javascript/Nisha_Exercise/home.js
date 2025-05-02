document.addEventListener('DOMContentLoaded', function () {
    var items = [
        { name: "Shirt", Image: "image 5.png", description: "2 years", price: "1400" },
        { name: "shirt", image: "dress-shirt-img.png", description: "2 years", price: "2400" },
        { name: "shirt", image: "image 6.png", description: "4 years", price: "1100" },
        { name: "shirt", image: "image 8.png", description: "4 years", price: "1100" },
        { name: "shirt", image: "image 9.png", description: "4 years", price: "1100" },
        { name: "frock", image: "women_cloth.png", description: "4 years", price: "1100" }
    ];
    var cart = [];
    listItems();
    function listItems() {
        var content = document.getElementById('content');
        content.innerHTML = ''; //clear any existing content
    }



});
