(function () {
    'use strict';

    function configure($stateProvider, $urlRouterProvider) {
        $stateProvider
        .state('home', {
            url: '/home',
            templateUrl: 'app/Sample/sample.html'
        });

        $stateProvider
        .state('startPage', {
            url: '/start',
            templateUrl: 'Client/app/views/demo.html'

        });

        $stateProvider
       .state('summaryPage', {
           url: '/summary',
           params: { cityName: {} },
           templateUrl: 'app/SummaryPage/summary.html'

       });

        $stateProvider
       .state('templaterender', {
           url: '/template',
           templateUrl: 'app/Start/DirTemplate.html'

       });

        $urlRouterProvider.rule(function ($injector, $location) {
            if ($location.protocol() === 'file') {
                return;
            }
            var path = $location.path()
            , search = $location.search
            , params
            ;
            if (path[path.length - 1] === '/') {
                return;
            }
            if (Object.keys(search).length === 0) {
                return path + '/';
            }
            params = [];
            angular.forEach(search, function (v, k) {
                params.push(k + '=' + v);
            });
            return path + '/?' + params.join('&');
        })
    }


    function routeAuthCheck($rootScope, Auth, $state) {
        Auth.init();
        $state.go('startPage');
        //starting code here
    }

    configure.$inject = ['$stateProvider', '$urlRouterProvider'];
    routeAuthCheck.$inject = ['$rootScope', 'Auth', '$state']

    angular.module('app')
    .config(configure)
    //.constant("moment", moment)
    .run(routeAuthCheck);

})();