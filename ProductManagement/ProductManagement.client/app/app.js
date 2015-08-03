﻿(function () {
    "use strict";

    var app = angular.module("productManagement",
                              ["common.services", "ui.router"]);

    app.config(["$stateProvider",
                "$urlRouterProvider",
                function ($stateProvider, $urlRouterProvider) {
                    $urlRouterProvider.otherwise("/");

                    $stateProvider
                        .state("home", {
                            url: "/",
                            templateUrl: "app/welcomeView.html"
                        })
                        //Products
                        .state("productList", {
                            url: "/products",
                            templateUrl: "app/products/productListView.html",
                            controller: "ProductListCtrl as vm"
                        })
                         .state("productDetail", {
                             url: "/products/detail:productId",
                             templateUrl: "app/products/productDetailView.html",
                             controller: "ProductDetailCtrl as vm",
                             resolve: {
                                 productResource: "productResource",

                                 product: function (productResource, $stateParams) {
                                     var productId = $stateParams.productId;
                                     return productResource.get(
                                         { Id: productId }).$promise;
                                 }
                             }
                         })
                        .state("productEdit", {
                            url: "/products/edit:productId",
                            templateUrl: "app/products/productEditView.html",
                            controller: "ProductEditCtrl as vm"
                        })
                }
    ]);
}());