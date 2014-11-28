var RegisterController = function ($scope) {

    $scope.registerForm = {
        emailAddress: '',
        password: '',
        confirmPassword:''
    };

    $scope.register = function () {

    }
}

RegisterController.$inject = ['$scope'];