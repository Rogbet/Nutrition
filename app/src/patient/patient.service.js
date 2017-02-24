(function() {
  'use strict';

  angular
    .module('app.patient')
    .factory('patientService', authService);

  //authService.$inject = ['$firebaseAuth', 'firebaseDataService'];

  function patientService($firebaseAuth, firebaseDataService) {
    
  }

})();