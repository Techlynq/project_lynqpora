(function(){
'use strict';

	angular.module('uq.core',[
		/*
		angular modules
		*/
		'ngMaterial',
		'ngMessages',
		'ngAnimate',
		'ngSanitize',
		'ngTouch',
		/*
		our app modules
		*/
		'blocks.exception',
		'blocks.logger',
		'blocks.router',
		'blocks.router.404',
		'blocks.users',
		'blocks.auth',

		/*
		third party modules
		*/
		'oc.lazyLoad',
		'ui.utils',
		'ngplus',
		'ui.router',
		'restangular',
		'ngMdIcons',
		'ngCookies',
		'ngFileUpload',
		'smoothScroll'
		]);

})();