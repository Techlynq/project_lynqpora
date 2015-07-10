(function(){
'use strict';
	
	angular.module('uq.core')
		   .constant('moment',moment)
		   .constant('toastr',toastr)
		   .constant('morlock',morlock)
		   .constant('TweenMax', TweenMax)
		   .constant('$', jQuery);
})();