// JavaScript Document

function getLeaf(url) {
    var splited = url.split("?");
    url = splited[0];
    return url.substring(url.lastIndexOf("/") + 1); // return file name without domain and path
}

jQuery.fn.extend({
    enter: function() {
        return this.each(function() {
            var pth = $(this).find("img")[0];
            if (getLeaf($(this).prop("href")) == getLeaf(document.location.href)
            ) { // check that the link url and document url is same
                $(pth).attr("src", pth.src.replace(/.gif/g, "_active.gif"));
            } else {
                // mouse over Image
                $(this).hover(function() {
                        $(pth).attr("src", pth.src.replace(/.gif/g, "_active.gif"));
                    },
                    function() {
                        $(pth).attr("src", pth.src.replace(/_active.gif/g, ".gif"));
                    });
            }
        });
    }
});
$(function() {
    $("#navbarNavAltMarkup #menuItems a").enter();
});