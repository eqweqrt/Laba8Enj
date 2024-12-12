CREATE TABLE Users (
    UserID SERIAL PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Role VARCHAR(20) NOT NULL,
    Status VARCHAR(20) NOT NULL,
    Photo BYTEA,
    Contract BYTEA
);

CREATE TABLE Orders (
    OrderID SERIAL PRIMARY KEY,
    TableNumber VARCHAR(20) NOT NULL,
    CustomerCount INT NOT NULL,
    OrderStatus VARCHAR(20) NOT NULL,
    WaiterID INT,
    FOREIGN KEY (WaiterID) REFERENCES Users(UserID)
);

CREATE TABLE OrderItems (
    OrderItemID SERIAL PRIMARY KEY,
    OrderID INT,
    DishName VARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

CREATE TABLE Shifts (
    ShiftID SERIAL PRIMARY KEY,
    ShiftDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL
);

CREATE TABLE ShiftAssignments (
    ShiftAssignmentID SERIAL PRIMARY KEY,
    ShiftID INT,
    UserID INT,
    FOREIGN KEY (ShiftID) REFERENCES Shifts(ShiftID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
