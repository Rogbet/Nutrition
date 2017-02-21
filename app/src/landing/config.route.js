(function() {
  'use strict';

  angular
    .module('app.landing')
    .config(configFunction);

  configFunction.$inject = ['$routeProvider'];

  function configFunction($routeProvider) {
    $routeProvider.when('/', {
      templateUrl: 'src/landing/landing.html'
    });
  }

})();