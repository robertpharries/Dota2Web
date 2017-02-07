var SearchController = function ($scope, $routeParams, $location) {
    $scope.searchForm = {
        accountId: ''
    };

    $scope.search = function () {
        $location.path('/results').search('id',$scope.searchForm.accountId);
    }
}

SearchController.$inject = ['$scope', '$routeParams', '$location'];