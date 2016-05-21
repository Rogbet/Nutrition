//angular.module('app')
//    .config(['$routeProvider', config]);

//function config($routeProvider) {
//    $routeProvider
//        .when('/', {
//            templateUrl: 'patientlist.html',
//            controller: 'PatientController',
//            controllerAs: 'vm'
//        });
//}

angular.module('app')
    .config(function ($stateProvider, $urlRouterProvider) {
        //
        // For any unmatched url, redirect to /state1
        $urlRouterProvider.otherwise("/home");
        //
        // Now set up the states
        $stateProvider
            .state('home', {
                url: "/home",
                templateUrl: "/scripts/app/home/index.html"
            })
        .state('patientcreate', {
            url: "/patient/create",
            templateUrl: "/scripts/app/patient/create.html",
            controller: 'PatientController',
            controllerAs: 'vm'
        })
        .state('patient', {
            url: "/patient/{id}",
            templateUrl: "/scripts/app/patient/index.html",
            controller: 'PatientController',
            controllerAs: 'vm'
        })
        .state('patientlist', {
            url: "/patients",
            templateUrl: "/scripts/app/patient/list.html",
            controller: 'PatientController',
            controllerAs: 'vm'
        })
    });