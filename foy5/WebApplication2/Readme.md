# WebApplication2

This project is an ASP.NET Core MVC application that manages faculties, departments, students, courses, and student-course enrollments. It uses Entity Framework Core as the ORM and SQL Server as the database.

## Features

- **Faculty Management**: CRUD operations for faculties.
- **Department Management**: CRUD operations for departments under faculties.
- **Student Management**: CRUD operations for students under departments.
- **Course Management**: Course listing and filtering based on year and semester.
- **Student-Course Enrollment Management**: CRUD operations for student-course enrollments, with search functionality.

## Controllers

### FakulteController

Handles CRUD operations for faculties.

- `Index()`: Displays a list of faculties ordered by `fakulteID` in descending order.
- `Create()`: Displays the form to create a new faculty.
- `Create(FakulteDto fakulteDto)`: Handles POST requests to create a new faculty.
- `Edit(int id)`: Displays the form to edit an existing faculty.
- `Edit(int id, FakulteDto fakulteDto)`: Handles POST requests to update an existing faculty.
- `Delete(int id)`: Deletes a faculty by `fakulteID`.

### BolumController

Handles CRUD operations for departments.

- `Index()`: Displays a list of departments ordered by `bolumID` in descending order.
- `Create()`: Displays the form to create a new department.
- `Create(BolumDto bolumDto)`: Handles POST requests to create a new department.
- `Edit(int id)`: Displays the form to edit an existing department.
- `Edit(int id, BolumDto bolumDto)`: Handles POST requests to update an existing department.
- `Delete(int id)`: Deletes a department by `bolumID`.

### OgrenciController

Handles CRUD operations for students.

- `Index()`: Displays a list of students ordered by `ogrenciID` in descending order.
- `Create()`: Displays the form to create a new student.
- `Create(OgrenciDto ogrenciDto)`: Handles POST requests to create a new student.
- `Edit(int id)`: Displays the form to edit an existing student.
- `Edit(int id, OgrenciDto ogrenciDto)`: Handles POST requests to update an existing student.
- `Delete(int id)`: Deletes a student by `ogrenciID`.

### DersController

Handles listing and filtering of courses.

- `Index(string searchString, string searchStringt)`: Displays a list of courses filtered by year (`yil`) and semester (`yariyil`). Supports filtering based on user input.

### OgrenciDersController

Handles CRUD operations for student-course enrollments.

- `Index(string searchString)`: Displays a list of student-course enrollments, filtered by `ogrenciID` if a search string is provided.
- `Create()`: Displays the form to create a new student-course enrollment.
- `Create(OgrenciDersDto ogrenciDersDto)`: Handles POST requests to create a new student-course enrollment.

## Models

### Fakulte

Represents a faculty in the application.

- `fakulteID`: Primary key, unique identifier for each faculty.
- `fakulteAd`: Name of the faculty.

### Bolum

Represents a department in the application.

- `bolumID`: Primary key, unique identifier for each department.
- `bolumAd`: Name of the department.
- `fakulteID`: Foreign key, references the `Fakulte` entity.

### Ogrenci

Represents a student in the application.

- `ogrenciID`: Primary key, unique identifier for each student.
- `ad`: First name of the student.
- `soyad`: Last name of the student.
- `bolumID`: Foreign key, references the `Bolum` entity.

### Ders

Represents a course in the application.

- `dersID`: Primary key, unique identifier for each course.
- `yil`: The year the course is offered.
- `yariyil`: The semester the course is offered.

### OgrenciDers

Represents the enrollment of a student in a course.

- `ogrenciID`: Foreign key, references the `Ogrenci` entity.
- `dersID`: Foreign key, references the `Ders` entity.
- `yil`: The year the course is taken.
- `yariyil`: The semester the course is taken.
- `vize`: Midterm exam grade.
- `final`: Final exam grade.
