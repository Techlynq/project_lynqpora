(function() {
    'use strict';

    angular
        .module('uq.directives')
        .directive('csSelect', csSelect);

    function csSelect() {
        return {
            restrict: 'A',
            link: function(scope, el, attrs) {
                if (!window.SelectFx){
                    return;
                }
                /* jshint ignore:start */
                var el = $(el).get(0);
                $(el).wrap('<div class="cs-wrapper"></div>');
                new SelectFx(el);
                /* jshint ignore:end */
            }
        };
    }
})();
