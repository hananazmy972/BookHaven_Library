# Library Management System Project (ADO.NET)

## Overview
This Library Management System is a desktop application designed to manage books, members, and borrowings within a library. Built using ADO.NET, the system allows for efficient tracking and management of library resources, with functionalities including book and member management, borrowing and returning operations, and overdue tracking. The project emphasizes data integrity, user feedback, and ease of use.
![Home Page](https://drive.google.com/file/d/1w_2z-pv-jxXeLHDDkkhA1W6H4wZKK29t/view?usp=drive_link)

## Project Components

### 1. Database Design:
The system utilizes a relational database to store and manage all the necessary information. The database is composed of the following tables:

- **Books**: Stores information about the books available in the library.
  - **Columns**: `BookID`, `Title`, `Author`, `ISBN`, `PublicationYear`, `CategoryID`, `TotalCopies`, `AvailableCopies`

- **Categories**: Stores the categories to which books belong.
  - **Columns**: `CategoryID`, `CategoryName`

- **Members**: Stores details of the library members.
  - **Columns**: `MemberID`, `FirstName`, `LastName`, `Email`, `PhoneNumber`, `JoinDate`

- **Borrowings**: Tracks the borrowing and returning of books by members.
  - **Columns**: `BorrowID`, `BookID`, `MemberID`, `BorrowDate`, `DueDate`, `ReturnDate`

### SQL Code
Here's the SQL code used to create the tables in the database:

```sql
-- Create Books Table
CREATE TABLE Book (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255) NOT NULL,
    Author VARCHAR(255) NOT NULL,
    ISBN VARCHAR(13) NOT NULL,
    PublicationYear INT NOT NULL,
    CategoryID INT NOT NULL,
    TotalCopies INT NOT NULL,
    AvailableCopies INT NOT NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Create Categories Table
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(100) NOT NULL
);

-- Create Members Table
CREATE TABLE Member (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    JoinDate DATE NOT NULL
);

-- Create Borrowings Table
CREATE TABLE Borrowing (
    BorrowID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT NOT NULL,
    MemberID INT NOT NULL,
    BorrowDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
```

### 2. Functionality:

#### a. Book Management:
- **Add** new books
- **Edit** existing book information
- **Delete** books (with safeguards)
- **Search** books by ID and Title
- **Filter** books by category

#### b. Member Management:
- **Register** new members
- **Edit** member information
- **Delete** members (with safeguards)
- **Search** members by name 

#### c. Borrowing and Returning:
- **Check out** books to members
- **Set due dates** automatically
- **Return** books and update availability
- **Display** currently borrowed books for a member by searching with the member's name
- **Overdue book tracking** by displaying overdue books

## Technologies Used:
- **ADO.NET**: For all database operations
- **BindingSource**: For data binding where appropriate
- **Parameterized Queries**: To prevent SQL injection
- **Exception Handling**: Implemented proper exception handling and user feedback
- **DataGridView**: To display lists of books, members, and borrowings
- **Data Validation**: Implemented for all input fields

## Video Demonstration
[Project Video Link Here]
