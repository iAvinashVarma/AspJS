(function () {
	var mainWindow = window.opener;
	var fileData = mainWindow.fileData;
	if (fileData !== null) {
		var app = angular.module('fileApp', ['ngAnimate', 'ngSanitize', 'ui.bootstrap']);
		app.controller('fileCtrl', function ($scope, $log) {
			this.fileData = fileData;
			$scope.totalItems = fileData.length;
			$scope.currentPage = 1;
			$scope.itemsPerPage = 10;
			$scope.maxSize = 5;

			$scope.$watch("currentPage", function () {
				setPagingData($scope.currentPage);
			});

			$scope.setPage = function (pageNo) {
				$scope.currentPage = pageNo;
			};
			$scope.pageChanged = function () {
				$log.log('Page changed to: ' + $scope.currentPage);
			};

			function setPagingData(page) {
				var pagedData = fileData.slice(
					(page - 1) * $scope.itemsPerPage,
					page * $scope.itemsPerPage
				);
				$scope.fData = pagedData;
			}
		});
	}
})();