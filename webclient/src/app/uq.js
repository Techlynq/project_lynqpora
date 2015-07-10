(function(){
	'use strict';

	angular
		.module('uq')
		.controller('UqController', UqController);

	UqController.$inject = ['$scope','$state']
	function UqController($scope,$state)
	{
		$scope.app = {
            name: 'Unilynq',
            description: 'Designing Application',
            layout: {
                menuPin: false,
                menuBehind: false,
                theme: '/app/pages/css/pages.css'
            },
            author: 'Issy'
        };

        // Checks if the given state is the current state
        $scope.is = function(name) {
            return $state.is(name);
        };

        // Checks if the given state/child states are present
        $scope.includes = function(name) {
            return $state.includes(name);
        };

        // Broadcasts a message to pgSearch directive to toggle search overlay
        $scope.showSearchOverlay = function() {
            $scope.$broadcast('toggleSearchOverlay', {
                show: true
            })
        };
	}
})();