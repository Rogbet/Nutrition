var app = angular.module('app', ['ui.router', 'ui.bootstrap', 'angularMoment']);

//global service
app.constant("utility",
{
    baseAddress: "http://localhost:63920/api/"
});

//app.run(function(amMoment) {
//    amMoment.changeLocale('es');
//});
