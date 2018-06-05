// Write your JavaScript code.
// define the module for our AngularJS application
var app = angular.module('App', []);

// invoke controller and retrieve data from $http service
app.controller('DataController', function ($scope, $http) {
    $http({
        url: 'localhost:8018/api/presidents/namesAscending',
        dataType: 'json',
        method: 'GET',
        data: '',
        headers: {
            "Content-Type": "application/json"
        }
    }).
    success(function (data) {
        $scope.presidents = data
    })
});