var app = angular.module('app');

app.factory('patientService', function ($http, utility) {
    var serviceurl = utility.baseAddress + "Patients/";

    return {
        getPatientsList: function(){
            var url = serviceurl;// + "GetUsersList";
            return $http.get(url);
        },
        getPatient: function (patient) {
            var url = serviceurl + patient.PatientID;
            return $http.get(url);
        },
        createPatient: function (patient) {
            var url = serviceurl + patient.PatientID;
            return $http.post(url, patient);
        },
        deletePatient: function (patient) {
            var url = serviceurl + patient.PatientID;
            return $http.delete(url);
        },
        updatePatient: function (patient) {
            var url = serviceurl + patient.PatientID;
            return $http.put(url, patient);
        }
    }

});
