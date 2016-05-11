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
        $urlRouterProvider.otherwise("/");
        //
        // Now set up the states
        $stateProvider
          .state('patients', {
              url: "/patients",
              templateUrl: "/scripts/app/patient/patientlist.html",
              controller: 'PatientController',
              controllerAs: 'vm'
          })
    });