
(function(){
    'use strict';

    angular
        .module('uq.directives')
        .directive('pgSearch', pgSearch);


    pgSearch.$inject = ['$parse'];
    function pgSearch($parse){
        return {
            restrict: 'A',
            link: function(scope, element, attrs) {
                $(element).search();

                scope.$on('toggleSearchOverlay', function(scopeDetails, status) {
                    if(status.show){
                        $(element).data('pg.search').toggleOverlay('show');
                    } else {
                        $(element).data('pg.search').toggleOverlay('hide');
                    }
                });

            }
        };
    }

})();