# Project - 1
Create a Console Application in C# for student management. The app doesn't need a backend database at this time and should meet the following requirements.


1. Each student will have: name, DOB, id, grade, courses
2. There can be any number of students in a class.
3. There are only few pre-defined courses from which the students can choose.

You console application should accept the inpt from the user for all the student data and store it in memory (i.e. collections). 

It should also allow the following operations:

1. Retrieve student by ID
2. Modify a student's properties like DOB, grade, courses etc. but not ID.
3. Get the total number of students in a class.
4. Get the age of a student as of today.


Please note that the student's attributes will follow all the common name conventions and the name will have 3 parts: first name, optional middle name, and last name.

# Project - 2
Now that you've learned ASP.NET MVC, upgrade the above Console Application to a Web MVC application. Make sure to:
1. Use repository pattern
2. Use database of your choice
3. Be able to perform CRUD operations
4. Display the students information using Datatables
5. Use areas for Teachers and Students.
6. Use the Toastr library to show any notifications

Think about how to show the courses to the students edit or create view. A student can be registered in multiple courses, hence using a dropdown with multi-select might be a good option.

Add a new model to the project for Teachers. Only the teachers will be able to add add courses (use areas for this). 

**Note that there is not need to make the application visually good. We'll take care of this later.**

# Capstone Project 
Create an API to manage the existing ASPNET MVC Student management project and integrate the Web API with the MVC application. 
1. Make sure to have proper authentication and authorization.
2. Dockerize the application
3. Deploy the app on Azure using Azure DevOps
4. Extra points for replacing the MVC app with Angular
5. Keep the Web API and the Frontend in different solutions and host them separately.
6. Follow CI/CD process to integrate the application with Github
7. Add unit tests to perform basic testing of your application. 
8. Use Azure Hosted SQL Server instead of SqlIte
