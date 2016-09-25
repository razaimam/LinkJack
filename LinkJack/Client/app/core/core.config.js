(function () {
    'use strict';

    function configure($httpProvider) {
        $httpProvider.interceptors.push('httpInterceptor');
    }

    configure.$inject = ['$httpProvider'];

    angular
    .module('app.core')
    .config(configure);

})();