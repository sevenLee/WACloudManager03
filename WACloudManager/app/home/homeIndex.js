/**
 * Created by seven on 15/3/13.
 */


console.log("into HomeController!");

rootCloudApp.controller("HomeController", function(domainData, waApi) {

    var vm = this;
    console.log("domainData in HomeController333:");
    console.log(domainData);

    //var dd = waApi.getHome();
    //console.log(dd);

    vm.domainInfo = domainData[0];

    //console.log("vm.domainInfo", vm.domainInfo);
    //console.log("vm.domainInfo.name", vm.domainInfo.name);

    /*
    domainInfoFactory.getUser().then(function(results){
      var data = results.data;
      console.log(data);
    });
    */

});

//HomeController.$inject = ['domainData'];

