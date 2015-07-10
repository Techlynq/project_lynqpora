(function(){
	'use strict';

	angular
		.module('uq', [
		/*
		 core modules provided...order is unimportant
		*/
		'uq.core',
		'uq.data', //needs core

		/*
		 feature modules
		*/
		'uq.dashboard',
		'uq.layout',
		'uq.landing',
		'uq.features',
		'uq.directives',
		'uq.animations',
		'uq.filters'
	]);
})();

