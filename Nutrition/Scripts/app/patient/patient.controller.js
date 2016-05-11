angular
    .module('app')
    .controller('PatientController', PatientController);

function PatientController() {
	var vm = this;

    vm.name = "Rogelio";
}