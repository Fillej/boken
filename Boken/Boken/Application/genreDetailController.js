app.controller("genreDetailController", ["$scope", "Genres", "$modalInstance", "param", function ($scope, Genres, $modalInstance, param) {
    //console.log("params in modal", params);
    console.log("view nummer:", param.view)
    $scope.view = param.view; //"0"; // s�tter redigeringsl�ge till false.

    // --- H�mtar genren ------ //
    $scope.$on("gotGenre", function (event, data) {
        $scope.genre = $scope.orgGenre = data;
     });
    Genres.get(param.id);
    // --- slut ---------------//

    // --- spara & Avbryt knapparnas funktioner -- //

    $scope.preSave = function () {


        //save($scope.genre.Id, $scope.genre);
        $modalInstance.close();
    };
    $scope.save = function () {
        Genres.put($scope.genre.Id, $scope.genre);
         $modalInstance.close();
    };
    
    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
    //-------------------------//
    
    // --- togglar redigeringsl�ge ---//
    
    $scope.editView = function (id) {
            if (id == 1) { $scope.view = [id]; }
            if (id == 0) { $scope.view = [id]; }
            if (id == 2) { $scope.view = [id]; }
    };
    // --- slut ---------------------//

}]);
