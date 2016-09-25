﻿(function () {
    'use strict';
    angular.module('blocks.exception')
    .provider('exceptionHandler', exceptionHandlerProvider)
    .config(config);

    function exceptionHandlerProvider() {
        this.config = {

            appErrorPrefix: undefined

        };
        this.configure = function (appErrorPrefix) {
            this.config.appErrorPrefix = appErrorPrefix;
        };
        this.$get = function () {
            return { config: this.config };
        };
    }

    function config($provide) {
        $provide.decorator('$exceptionHandler', extendExceptionHandler);
    }

    function extendExceptionHandler($delegate, $injector, exceptionHandler) {
        return function (exception, cause) {
            var appErrorPrefix = exceptionHandler.config.appErrorPrefix || '';
            var logger = $injector.get("logger");
            var errorData = { exception: exception, cause: cause };
            exception.message = appErrorPrefix + exception.message;
            $delegate(exception, cause);

            logger.error(exception.message, errorData);

        }

    }


})();