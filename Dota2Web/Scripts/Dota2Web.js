var Dota2Web = angular.module("Dota2Web", ['ngRoute', 'ngMaterial', 'angular-loading-bar']);

Dota2Web.controller('LandingPageController', LandingPageController);
Dota2Web.controller('AppCtrl', [function ($scope) {
}]);

var configFunction = function($routeProvider, $locationProvider) {
    $routeProvider
        .when('/search', {
            templateUrl: 'Routes/search'
        })
        .when('/about', {
            templateUrl: 'Routes/about'
        })
        .when('/results', {
            templateUrl: function (p) { return "Routes/results?id=" + p.id; }
        });
}

configFunction.$inject = ['$routeProvider'];

Dota2Web.config(configFunction);

// title controller
var titleFunction = function ($scope) {
    $scope.models = {
        title: 'Dota 2 Web'
    };
};

titleFunction.$inject = ['$scope'];

Dota2Web.controller('TitleController', titleFunction);

// search controller
var SearchController = function ($scope, $routeParams, $location) {
    $scope.searchForm = {
        accountId: ''
    };

    $scope.search = function () {
        $location.path('/results').search('id', $scope.searchForm.accountId);
    }
}

SearchController.$inject = ['$scope', '$routeParams', '$location'];

Dota2Web.controller('SearchController', SearchController);

