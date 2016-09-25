(function () {
    'use strict';
    function AuthService($q, $http, exception, $location) {

        var service = {
            init: init,
            getUserProfile: getUserProfile

        };

        return service;

        function init() {
            getUserProfile().then(function (data) {
                service.userProfile = data;
            });
        }

        function getUserProfile() {
            return $http.get('api/profile')
            .then(function (res) {
                return res.data;
            })
            .catch(function (message) {
                exception.catcher('server error')(message)
            })


        }
    }
    AuthService.$injct = ['$q', '$http', 'exception', '$location'];

    angular
    .module('app.core')
    .factory('Auth', AuthService);


})();