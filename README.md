# Student Enrollment Application
#### Description: A C# desktop application that stores student information into a mySQL database. A final requirement for CpE Software Design course.
### Developers:
- [Ivan G. Suralta](https://github.com/ivanovich18)
- [Aldrin A. Felices](https://github.com/bossaldrin)
### Technologies Used:
- **C#**
- **MySQL**
### Project Preview:
![PaO8uK0L5Mw](https://github.com/ivanovich18/Student-Enrollment-Application/assets/88656474/8ea7f3b5-bf29-41c4-a844-deef04cafccb)
![PaO8uK0L5Mw (2)](https://github.com/ivanovich18/Student-Enrollment-Application/assets/88656474/675ed2fe-5c5a-4573-88f9-440da0d8a23c)
![PaO8uK0L5Mw (3)](https://github.com/ivanovich18/Student-Enrollment-Application/assets/88656474/67d9ec7e-bc49-4e57-80b1-df8d306fdbfe)
### How to use:
-This application uses MySQL using XAMPP control panel as its database.
####Step 1: Download and Install XAMPP
- Go to the XAMPP website (https://www.apachefriends.org/index.html) and download the appropriate version for your operating system (Windows, macOS, or Linux).
- Run the installer and follow the on-screen instructions to install XAMPP.
####Step 2: Start the XAMPP Control Panel
- Once the installation is complete, locate the XAMPP Control Panel and launch it.
- Start the Apache and MySQL modules by clicking the "Start" button next to each module.
- Step 3: Import the Database

-Open your web browser and enter "http://localhost/phpmyadmin" in the address bar. This will open the phpMyAdmin interface.
-Click on the "New" button to create a new database. Provide a name for your database and click "Create".
-Once the database is created, click on its name in the left sidebar to open it.
-Click on the "Import" tab in the top navigation menu.
-Click on the "Choose File" button and select the database file (usually a .sql file) that is provided with your C# app.
-Finally, click the "Go" button to import the database.
####Step 4: Update Connection String in the C# App

-Open your C# app project in your preferred development environment (e.g., Visual Studio).
-Locate the file or code section where the database connection string is defined.
-Update the connection string to point to the MySQL database running on your local machine. The connection string should include the hostname (localhost), port number (usually 3306), database name, username, and password.
#### Step 5: Build and Run the C# App

- Build your C# app to ensure that all dependencies are resolved and there are no compilation errors.
- Once the build is successful, run the C# app. It should connect to the MySQL database and be ready for use.
