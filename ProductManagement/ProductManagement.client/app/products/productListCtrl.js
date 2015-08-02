(function () {
    "use strict";
    angular
        .module("productManagement")
        .controller("ProductListCtrl",
                    productListCtrl);

    function productListCtrl() {
        var vm = this;
        vm.products = [
                {
                    $id: "1",
                    productName: "Leaf Rake",
                    productCode: "GDC-0011",
                    description: "a Leaf Rake",
                    releaseDate: "2012-08-12T00:00:00",
                    price: 20,
                    imageUrl: "http://www.bulldogtools.co.uk/gen/thumbs/23k42boczfbxpm25cufr4ybgk4-7w6ta3ag2qvrnvjd7c2ogb44diqtnqju-large.jpg",
                    id: 1
                },
                {
                    $id: "2",
                    productName: "Hammer",
                    productCode: "GDC-0012",
                    description: "a Hammer",
                    releaseDate: "2013-09-12T00:00:00",
                    price: 25,
                    imageUrl: "http://s.hswstatic.com/gif/hammer-1.jpg",
                    id: 2
                }
        ]

        vm.showImage = false;

        vm.toogleImage = function () {
            vm.showImage = !vm.showImage;
        }
    }
}());