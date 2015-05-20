rootCloudApp.factory('domainInfoFactory', ["$http",
  function($http){
    var getUser = function(){
      return $http.get("User/GetUser");
    }

    return {
      getUser: getUser
    }

}]);