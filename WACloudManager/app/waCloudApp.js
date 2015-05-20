
if (typeof $ === 'undefined') { throw new Error('This application\'s JavaScript requires jQuery'); }



  var rootCloudApp = angular.module('waCloudApp', ['ui.router']);
  

  rootCloudApp.config(['$stateProvider', '$urlRouterProvider', configRoutes]);

  function configRoutes($stateProvider, $urlRouteProvider){

    $urlRouteProvider.otherwise('/DomainHome');

    $stateProvider

      .state('app',{
        abstract:true,
        controller:'mainController'
      })
      .state('app.home',{
        url:'/DomainHome',
        templateUrl:'/SingleView/HomePage',
        controller: 'HomeController',
        controllerAs:'vm',
        resolve:{
            domainData: function (waApi) {
              return waApi.getHome();
            }
        }
      });
//      .state('app.devicemanage',{
//        url:'/DeviceManagement',
//        templateUrl:'/SingleView/DeviceManagement',
//        controller: 'deviceManageCtrl',
//        controllerAs:'vm'
////        resolve:{
////          initialData:['waApi',function(waApi){
////            return waApi.getDevices();
////          }]
////        }
//      })
      //.state('app.taggroup',{
      //  url:'/TagGroup',
      //  templateUrl:'/SingleView/TagGroup',
      //  controller: 'tagGroupCtrl'
      //});


  }
