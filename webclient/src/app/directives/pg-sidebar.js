

(function(){
	'use strict';

	angular
		.module('uq.directives')
    	.directive('pgSidebar', pgSidebar);

    function pgSidebar(){
        return {
            restrict: 'A',
            link: function(scope, element, attrs) {
                var $sidebar = $(element);
            	$sidebar.sidebar($sidebar.data());
            }
        };
    }
})();