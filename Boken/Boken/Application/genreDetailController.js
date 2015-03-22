app.controller("genreDetailController", ["$scope", "Genres", "$modalInstance", "param", function ($scope, Genres, $modalInstance, param) {

    $scope.view = param.view; // s�tter viken vy som ska visas.
    $scope.action = param.view; // talar om vilken handling anv�ndaren vill utf�ra i modalen
    $scope.genre = {};
    // --- H�mtar genren ------ //
    $scope.$on("gotGenre", function (event, data) {
        $scope.genre = data;
    });
    Genres.get(param.id);
    // --- slut ---------------//

    // --- spara & Avbryt knapparnas funktioner -- //
    //     st�nger �ven ner modalen 

    $scope.save = function () {
        Genres.put($scope.genre.Id, $scope.genre);
        $modalInstance.close();
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
    //-------------------------//

    // --- logik f�r att best�mma vad som skrivs ut i bekr�ftelse
    $scope.text = "";
    $scope.text2 = "";
    $scope.editText = function () {
        var a = $scope.action;
        var text = "Vill du verkligen "
        if (a == 1) text += "uppdatera "
        if (a == 4) text += "skapa "
        if (a == 3) text += "ta bort ";
        text += "genren "

        var text2 = "";
        if (a != 3) text2 = "med foljande innehall?"
        if (a == 3) text2 = "och alla dess referenser permanent?";
        if (a == 4) text2 = "med dessa uppgifter?";
        $scope.text2 = text2;
        $scope.text = text;
        console.log("bekr�ftafunktionen s�ger: ", $scope.action);
    }
    // ------------------------//
    
    //---------skapa ny -------//
    $scope.create = function () {
        Genres.post($scope.genre);
        $modalInstance.close();
    };
    // ----------slut ------------------//

    // ----- Delete ------------------- //

    $scope.delete = function () {
        try {
            Genres.delete($scope.genre.Id);
        }
        catch (err) {
        }
        $modalInstance.close();
    };

    //---------Slut delete -------------//

    // --- togglar mellan olika vyer ---//
    /*
     * View:
     *  0 - visa upp
     *  1 - redigering
     *  2 - bekr�ftelse
     *  3 - radera
     *  4 - skapa nytt
     * 
     */

    $scope.editView = function (id) {
        if (id == 1) { $scope.view = [id]; }
        if (id == 0) { $scope.view = [id]; }
        if (id == 2) { $scope.view = [id]; }
    };
    // --- slut ---------------------//

}]);
