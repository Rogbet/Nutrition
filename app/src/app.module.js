(function() {
'use strict';

// Declare app level module which depends on views, and components
angular.module('app', [
  'ngRoute',
  'app.version',
  // Third party modules.
  'firebase',

  // Custom modules.
  'app.auth',
  'app.core',
  'app.landing',
  'app.layout',
  'app.patient'
])
.config(configFunction)
.run(runFunction);

function configFunction($routeProvider) {
    $routeProvider.otherwise({
      redirectTo: '/'
    });
  }

  runFunction.$inject = ['$rootScope', '$location'];

  function runFunction($rootScope, $location) {
    $rootScope.$on('$routeChangeError', function(event, next, previous, error) {
      if (error === "AUTH_REQUIRED") {
        $location.path('/');
      }
    });
  }

})();