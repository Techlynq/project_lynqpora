(function(){
    'use strict';

    angular
        .module('uq.directives')
        .directive('skycons', skycons);

    function skycons(){
        return {
            restrict: 'A',
            link: function(scope, element, attrs) {
                /* jshint ignore:start */
                var skycons = new Skycons();
                skycons.add($(element).get(0), attrs.class);
                skycons.play();
                /* jshint ignore:end */
            }
        };
    }
})();