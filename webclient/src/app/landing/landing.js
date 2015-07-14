(function(){
	'use strict';

	angular
		.module('uq.landing')
		.controller('Landing', Landing);

	Landing.$inject = ['$scope','$timeout','routehelper'];
	function Landing($scope,$timeout,routehelper){
		$scope.message = 'How are you doing today?';
	}
	
})();