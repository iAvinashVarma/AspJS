(function () {
	var mainWindow = window.opener;
	var fileData = mainWindow.fileData;
	if (fileData !== null) {
		var app = angular.module('fileApp', ['ngAnimate', 'ngSanitize', 'ui.bootstrap']);
		app.controller('mainCtrl', function ($scope, $log) {
			$scope.title = "Reports - " + new Date();
		});
		app.controller('fileCtrl', function ($scope, $log) {
			this.fileData = fileData;
			$scope.totalItems = fileData.length;
			$scope.currentPage = 1;
			$scope.itemsPerPage = 10;
			$scope.maxSize = 5;
			$scope.serverPath = function (fileDatum, fileName) {
				return fileDatum.serverUrl + fileDatum.reportDirectory + fileName;
			};
			$scope.openFile = function (fileDatum, fileName) {
				var serverPath = $scope.serverPath(fileDatum, fileName);
				var data = readTextFile(serverPath);
				$scope.fileContent = data;
				$scope.currentFileName = fileName;
			};
			$scope.saveFile = function (fileDatum, fileName) {
				var serverPath = $scope.serverPath(fileDatum, fileName);
				var data = readTextFile(serverPath);
				if (data !== null) {
					var blob = new Blob([data], { type: 'text/csv' });
					if (window.navigator.msSaveOrOpenBlob) {
						window.navigator.msSaveBlob(blob, fileName);
					}
					else {
						var elem = window.document.createElement('a');
						elem.href = window.URL.createObjectURL(blob);
						elem.download = fileName;
						document.body.appendChild(elem);
						elem.click();
						document.body.removeChild(elem);
					}
				}
			};
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
			};
			function readTextFile(file) {
				var data;
				var rawFile = new XMLHttpRequest();
				rawFile.open("GET", file, false);
				rawFile.onreadystatechange = function () {
					if (rawFile.readyState === 4) {
						if (rawFile.status === 200 || rawFile.status === 0) {
							data = rawFile.responseText;
						}
					}
				};
				rawFile.send(null);
				return data;
			};
		});
	}
})();