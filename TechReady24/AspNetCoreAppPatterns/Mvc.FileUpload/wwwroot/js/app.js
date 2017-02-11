﻿/// <reference path="models.js" />

var User = (function () {
    function User(name, age, zipCode, curriculumVitae) {
        this.name = name;
        this.age = age;
        this.zipCode = zipCode;
        this.curriculumVitae = curriculumVitae;
    }
    return User;
}());

var myApp = angular.module('myApp', []);
myApp.directive('fileModel', ['$parse', function ($parse) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            var model = $parse(attrs.fileModel);
            var modelSetter = model.assign;

            element.bind('change', function () {
                scope.$apply(function () {
                    modelSetter(scope, element[0].files[0]);
                });
            });
        }
    };
}]);

myApp.service('userService', ['$http', function ($http) {
    this.createUser = function (user) {
        var fd = new FormData();
        fd.append('name', user.name);
        fd.append('age', user.age);
        fd.append('zipCode', user.zipCode);
        fd.append('curriculumVitae', user.curriculumVitae);

        return $http.post('/file/upload', fd, {
                transformRequest: angular.identity,
                headers: { 'Content-Type': undefined
            }
        });
}
}]);

myApp.controller('myCtrl', ['$scope', 'userService', function ($scope, userService) {
    $scope.createUser = function () {
        $scope.showUploadStatus = false;
        $scope.showUploadedData = false;

        var user = new User($scope.name, $scope.age, $scope.zipCode, $scope.curriculumVitae)

        userService.createUser(user).then(function (response) { // success
            if (response.status == 200) {
                $scope.uploadStatus = "User created sucessfully.";
                $scope.uploadedData = response.data;
                $scope.showUploadStatus = true;
                $scope.showUploadedData = true;
        }
        },
        function (response) { // failure
            $scope.uploadStatus = "User creation failed with status code: " + response.status;
            $scope.showUploadStatus = true;
            $scope.showUploadedData = false;
        });
};
}]);