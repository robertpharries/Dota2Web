var Dota2Web = angular.module("Dota2Web", ['ngRoute']);

Dota2Web.controller('LandingPageController', LandingPageController);
Dota2Web.controller('SearchController', SearchController);

var configFunction = function($routeProvider, $locationProvider) {
    $routeProvider
        .when('/search', {
            controller: SearchController,
            templateUrl: 'Routes/search'
        })
        .when('/about', {
            templateUrl: 'Routes/about'
        })
        .when('/results', {
            controller: SearchController,
            templateUrl: function (p) { return "Routes/results?id=" + p.id; }
        });
}

configFunction.$inject = ['$routeProvider'];

Dota2Web.config(configFunction);