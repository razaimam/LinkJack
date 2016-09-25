(function () {
    'use strict';

    function logger($log, toaster) {
        var service = {
            error: error,
            info: info,
            success: success,
            warning: warning
        };
        return service;

        function error(message, data) {
            toaster.pop('error', "Sample App", message)
            $log.error(message, data);
        }

        function info(message, data) {
            toaster.pop('note', "Sample App", message)
            $log.info(message, data);
        }
        function success(message, data) {
            toaster.pop('success', "Sample App", message)
            $log.info(message, data);
        }
        function warning(message, data) {
            toaster.pop('warning', "Sample App", message)
            $log.warn(message, data);
        }
    }

    logger.$inject = ['$log', 'toaster']

    angular
        .module('blocks.logger')
        .factory('logger', logger);

})();