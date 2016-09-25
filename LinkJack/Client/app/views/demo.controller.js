(function () {
    'use strict';
    function demoCtrl($scope, $http, Auth) {
        var sam = this;

        Auth.getUserProfile()
            .then(function (data) {
                sam.user = data;

            })


    }
    demoCtrl.$inject = ['$scope', '$http', 'Auth']

    angular
    .module('app.core')
    .controller('demoCtrl', demoCtrl);

})();