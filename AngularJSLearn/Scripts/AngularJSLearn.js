var AngularJSLearn = angular.module('AngularJSLearn', ['ngRoute']);
AngularJSLearn.controller('LandingPageController', LandingPageController);
AngularJSLearn.controller('LoginController', LoginController);
AngularJSLearn.controller('RegisterController', RegisterController);


AngularJSLearn.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider
        .when('/routeOne', { templateUrl: 'RoutesDemo/One' })
    .when('/routeTwo/:donuts', { templateUrl: function (params) { return '/RoutesDemo/two?donuts=' + params.donuts; } })
    .when('/routeThree', { templateUrl: 'RoutesDemo/Three' })
    .when('/login', { templateUrl: '/Account/Login', controller: LoginController })
    .when('/register', { templateUrl: '/Account/Register', controller: RegisterController });
    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');
}
configFunction.$inject = ['$routeProvider','$httpProvider'];
AngularJSLearn.config(configFunction);
