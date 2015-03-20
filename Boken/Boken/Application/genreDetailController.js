app.controller("genreDetailController", ["$scope", "Genres", "$modalInstance", "param", function ($scope, Genres, $modalInstance, param) {

    $scope.view = param.view; // s�tter viken vy som ska visa.

    // --- H�mtar genren ------ //
    $scope.$on("gotGenre", function (event, data) {
        $scope.genre = $scope.orgGenre = data;
     });
    Genres.get(param.id);
    // --- slut ---------------//

    // --- spara & Avbryt knapparnas funktioner -- //

    $scope.save = function () {
        Genres.put($scope.genre.Id, $scope.genre);
        $modalInstance.close();
         
    };
    
    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
    //-------------------------//

    // ----- Delete ----------------------- //

    $scope.delete = function () {
        
            try {
                Genres.delete($scope.genre.Id);
                alert("Genren" + $scope.genre.Name + "och dess referenser �r borttagna.");
            }
            catch (err) {
                alert("N�got gick fel:  " + err);
            }
        
            $modalInstance.close();
    };

    //---------Slut delete -------------------//







    
    // --- togglar redigeringsl�ge ---//
    
    $scope.editView = function (id) {
            if (id == 1) { $scope.view = [id]; }
            if (id == 0) { $scope.view = [id]; }
            if (id == 2) { $scope.view = [id]; }
    };
    // --- slut ---------------------//

}]);
