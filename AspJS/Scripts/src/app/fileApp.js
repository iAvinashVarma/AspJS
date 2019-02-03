(function () {
	var mainWindow = window.opener;
	var fileData = mainWindow.fileData;
	if (fileData != null) {
		var app = angular.module('fileApp', ['ngAnimate', 'ngSanitize', 'ui.bootstrap']);
		app.controller('fileCtrl', function () {
			this.fileData = fileData;
		});
	}
})();