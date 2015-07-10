(function(){
    'use strict';

    angular
        .module('uq.directives')
        .directive('pgFormGroup',pgFormGroup);

    function pgFormGroup(){
        return {
            restrict: 'A',
            link: function(scope, element, attrs) {
                $(element).on('click', function() {
                    $(this).find(':input').focus();
                });
                $(element).find(':input').on('focus', function() {
                    $('.form-group.form-group-default').removeClass('focused');
                    $(element).addClass('focused');
                });
                $(element).find(':input').on('blur', function() {
                    $(element).removeClass('focused');
                    if ($(this).val()) {
                        $(element).find('label').addClass('fade');
                    } else {
                        $(element).find('label').removeClass('fade');
                    }
                });
                $(element).find('.checkbox, .radio').hover(function() {
                    $(this).parents('.form-group').addClass('focused');
                }, function() {
                    $(this).parents('.form-group').removeClass('focused');
                });
            }
        };
    }
})();