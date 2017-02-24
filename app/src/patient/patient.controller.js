(function() {
  'use strict';

  angular
    .module('app.patient')
    .controller('PatientController', AuthController);

  AuthController.$inject = ['$location', 'patientService', 'user'];

  function PatientController($location, patientService, user) {
    var vm = this;

    // vm.patients  = patientService.getPatientsByUser(user.uid);
  }

})();