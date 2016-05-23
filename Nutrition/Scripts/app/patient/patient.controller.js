angular
    .module('app')
    .controller('PatientController', PatientController);

PatientController.$inject = ['$scope','patientService', '$location', '$stateParams'];

function PatientController($scope,patientService, $location, $stateParams) {
    var vm = this;

    vm.loading = false;
    vm.patient = new Object();
    vm.GenderChk = "male";
    vm.showSuccessAlert = false;
    vm.patients = [];

    vm.options = {
        showWeeks: false
    };

    vm.now = new Date();

    vm.today = function () {
        vm.patient.BirthDate = new Date();
    };

    vm.today();

    vm.closeAlert = function (index) {
        vm.showSuccessAlert = false;
    };

    (function () {
        var path = $location.path();
        if (path = "/patients") {
            patientService.getPatientsList().success(function (data) {
                vm.patients = data;
            }).error(function (data) {
                vm.error = "An Error has occured while Loading patients! " + data.ExceptionMessage;
            });
        }
    })();

    vm.create = function () {
        var currentPatient = this.patient;
        vm.loading = true;
        if (currentPatient != null && currentPatient.Name != null && currentPatient.BirthDate && vm.GenderChk) {
            if (vm.GenderChk == "male")
                currentPatient.Gender = 0;
            else if (vm.GenderChk == "female")
                currentPatient.Gender = 1;

            patientService.createPatient(currentPatient).success(function (data) {

                currentPatient.PatientID = data;
                vm.patients.push(currentPatient);

                //reset form
                vm.patient = new Object();
                vm.today();
                vm.GenderChk = "male";
                vm.loading = false;
                vm.showSuccessAlert = true;

                vm.createPatient.$setPristine();

            }).error(function (data) {
                vm.error = "An Error has occured while Adding user! " + data.ExceptionMessage;
                vm.loading = false;
            });
        }
    };
}