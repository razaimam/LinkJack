(function () {
    'use strict';

    function loader($rootScope) {
        return function ($scope, element, attrs) {

            $scope.$on("loader_show", function () {
                return element.show();

            });

            return $scope.$on("loader_hide", function () {
                return element.hide();
            });
        };
    }
    loader.$inject = ['$rootScope'];
    function renderTemplate() {
        return function ($scope, element, attrs) {

        }

    }

    angular
    .module('app.core')
    .directive('loader', loader);

})();