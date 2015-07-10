(function(){
	'use strict';

	angular.module('uq.data')
		   .factory('datacontext', datacontext);


	datacontext.$inject = [];
    function datacontext(){
    	var service = {
    		ready: ready
    	};	

    	return service;

    	function ready(){
    		return true;
    	}
    }

})();