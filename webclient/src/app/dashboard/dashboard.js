(function(){
	'use strict';

	angular.module('uq.dashboard')
		   .controller('Dashboard', Dashboard);

	Dashboard.$inject = ['$scope','auth'];
	function Dashboard($scope,auth){
		var vm = this;

		$scope.isUser = false;
		$scope.isHotel = false;

		activate();

	function activate(){
		auth.user()
		.then(function(user){
			$scope.user = user;
		    $scope.isHotel = auth.role() === 'Hotel' ? true : false;
		    $scope.isUser = auth.role() === 'Hotel' ? false : true;
		},function(error){

		});
								
	}

	$scope.liveSearch = function() {
        console.log('Live search for: ' + $scope.search.query);
    };

	// function setUserRole()
	// {
	// 	$scope.isUser = true;
	// }

	// function setHotelRole()
	// {
	// 	$scope.isHotel = true;
	// }
}
})();

