(function(){
	'use strict';

	angular
		.module('blocks.auth')
		.factory('AuthToken', AuthToken);

	AuthToken.$inject = ['$window','$q'];
	function AuthToken($window,$q){
		var storage = $window.localStorage;
		var session = $window.sessionStorage;
		var cachedToken = JSON.parse(storage.getItem('userToken')) || {token: ''};

		var service = {
			setToken: setToken,
			getToken: getToken,
			isAuthenticated: isAuthenticated,
			removeToken: removeToken
		};

		return service;
		///////////////

		function setToken(tokenObject){

			if(typeof tokenObject !== 'undefined'){
				storage.setItem('userToken', JSON.stringify(tokenObject));
				cachedToken = tokenObject;
				return true;
			}
			
			return false;
		}

		function getToken(){
			if(typeof cachedToken === 'object'){
				return cachedToken || {token: ''};
			}else{
				return JSON.parse(cachedToken);
			}
			
		}

		function isAuthenticated(){
			var deferred = $q.defer();			
			return !!(JSON.parse(storage.getItem('userToken')) || cachedToken.token);
		}

		function removeToken(){
			var deferred = $q.defer();

			cachedToken = {token: ''};
			storage.removeItem('userInfo');
			storage.removeItem('userToken');
			storage.removeItem('userType');

			if(!cachedToken.token){
				deferred.resolve(true);
			}else{
				deferred.reject(false);
			}

			return deferred.promise;
		}
	}

})();