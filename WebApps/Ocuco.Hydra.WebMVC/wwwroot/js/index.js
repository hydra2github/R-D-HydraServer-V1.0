$(document).ready(function () {

    var x = 0;
    var s = "";

    console.log("ciao ciao");

    //--------------------------------------------------------

    // var theForm = document.getElementById("theForm");
    // theForm.hidden = true;

    // jQuery version
    var theForm = $("#theForm");
    theForm.hide();

    //--------------------------------------------------------

    //var button = document.getElementById("buyButton");
    //button.addEventListener("click", function () {
    //    alert("prova bottone");
    //});

    // jQuery version
    var button = $("#buyButton");
    button.on("click", function () {
        console.log("prova bottone");
    })

    //--------------------------------------------------------

    //var productInfo = document.getElementsByClassName("product-props");
    //var listItems = productInfo.item[0].children;

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You click on " + $(this).text());
    });

    //--------------------------------------------------------

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $popupForm.hide();

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });


});