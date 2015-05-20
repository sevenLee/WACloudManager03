rootCloudApp.factory('waApi', waApi);

waApi.$inject = ['$http', '$q'];

function waApi($http, $q){


  var userVMURL = '/User/GetUser';



  var service = {
    getHome: getHome,
    getDevices: getDevices

  };

  //var jsonDevicesUrl = '/DataJson/data-devices.json';



  return service;

  function getHome(){


    //final return  response.data
    //not return  promise
    return $http({
      url:userVMURL
    })
    .then(function(response){
      console.log("get domain information success");
      console.log(response);

      //todo:appSpinner.hideSpinner();

      return response.data;
      },
      function(){
      //error
        alert('Failure loading json');
    });

  }

  function getDevices(){

    return httpResolver(jsonDevicesUrl, 'GET');
  }

  function httpResolver(requestUrl, method, data){
    return $http({
        url:requestUrl,
        method:method,
        data:data})
      .then(function(response){
        return response.data;
      },function(response){

        //error

      	console.log('json load error', response);

       // debugger;
    });
  }

}