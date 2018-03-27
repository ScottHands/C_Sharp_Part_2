// Class to represent a row in the seat reservations grid
function SeatReservation(name, initialMeal) {
    var self = this;
    self.name = name;
    self.meal = ko.observable(initialMeal);
}

// Overall viewmodel for this screen, along with initial state
function ReservationsViewModel() {
    var self = this;

    // Non-editable catalog data - would come from the server
    self.availableMeals = [
        { mealName: "New York Steak", price: 26.00 },
        { mealName: "Lobster Tail and Sirloin Cut", price: 35.00 },
        { mealName: "Ultimate Feast", price: 42.00 }
    ];

    // Editable data
    self.seats = ko.observableArray([
        new SeatReservation("He-Man", self.availableMeals[1]),
        new SeatReservation("Skeletor", self.availableMeals[2])
    ]);

    self.addSeat = function () {
        self.seats.push(new SeatReservation("Man-E-Faces", self.availableMeals[2]))
    }

    self.removeSeat = function (seat) { self.seats.remove(seat) }
}

function SeatReservation(name, initialMeal) {
    var self = this;
    self.name = name;
    self.meal = ko.observable(initialMeal);

    self.formattedPrice = ko.computed(function () {
        var price = self.meal().price;
        return price ? "$" + price.toFixed(2) : "None";
    });
}
ko.applyBindings(new ReservationsViewModel());