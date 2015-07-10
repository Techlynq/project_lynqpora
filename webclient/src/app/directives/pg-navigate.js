(function(){
    'use strict';

    angular
        .module('uq.directives')
        .directive('pgNavigate', pgNavigate);

    function pgNavigate(){
        return {
            restrict: 'A',
            link: function(scope, element, attrs) {

                $(element).click(function() {
                    var el = $(this).attr('data-view-port');
                    if ($(this).attr('data-toggle-view') !== null) {
                        $(el).children().last().children('.view').hide();
                        $($(this).attr('data-toggle-view')).show();
                    }
                    $(el).toggleClass($(this).attr('data-view-animation'));
                    return false;
                });


            }
        };
    }
})();