DCIT318 Assignment 1 - Complete Three Projects
Grade Calculator
Prompts user for numerical grade (0-100). Displays letter grade: A (90+), B (80-89), C (70-79), D (60-69), F (below 60). Includes error handling for invalid input and range validation.

Ticket Price Calculator
Movie theater charges GHC10 regular ticket. Children (12 & under) and Seniors (65+) receive discounted price of GHC7. Prompts user for age, calculates appropriate price, displays customer type and ticket cost.

Triangle Type Identifier
Prompts for three side lengths. Validates triangle inequality theorem. Identifies type: Equilateral (all sides equal), Isosceles (two sides equal), Scalene (no sides equal). Includes error handling for invalid inputs and non-triangle combinations.

All three applications are combined in one C# console program with a main menu for easy navigation. Each application includes input validation, error handling, and clear output formatting.

Launch Each Application Separately
Option A: Three Separate Project Files
Create three separate console applications:

bash
# 1. Grade Calculator
dotnet new console -n GradeCalculator
cd GradeCalculator
# Paste Grade Calculator code
dotnet run

# 2. Ticket Price Calculator
cd ..
dotnet new console -n TicketPriceCalculator
cd TicketPriceCalculator
# Paste Ticket Price Calculator code
dotnet run

# 3. Triangle Type Identifier
cd ..
dotnet new console -n TriangleTypeIdentifier
cd TriangleTypeIdentifier
# Paste Triangle Type Identifier code
dotnet run
Option B: Quick Launch Script
Create launch_all.bat:

batch
@echo off
echo ========================================
echo   DCIT318 ASSIGNMENT 1 - ALL PROJECTS
echo ========================================
echo.
echo 1. Run Grade Calculator
echo 2. Run Ticket Price Calculator
echo 3. Run Triangle Type Identifier
echo 4. Run Combined Application
echo 5. Exit
echo.
set /p choice="Enter your choice (1-5): "

if %choice%==1 (
    dotnet run --project GradeCalculator
) else if %choice%==2 (
    dotnet run --project TicketPriceCalculator
) else if %choice%==3 (
    dotnet run --project TriangleTypeIdentifier
) else if %choice%==4 (
    dotnet run --project DCIT318Assignment1
) else (
    exit
)
Method 3: Using Visual Studio
Open Visual Studio

File → Open → Project/Solution

Navigate to your project folder

Open DCIT318Assignment1.csproj

Press F5 or Start button

Navigation in Visual Studio:
The application opens with the main menu

Press 1, 2, or 3 to launch each calculator

After each calculation, press any key to return

Press 4 to exit

Method 4: Using Visual Studio Code
bash
# 1. Open VS Code
code .

# 2. Open Terminal (Ctrl + `)
# 3. Run the application
dotnet run

# 4. Follow the menu to launch each calculator
Quick Reference Card
Action	Command/Key
Create project	dotnet new console -n DCIT318Assignment1
Navigate to project	cd DCIT318Assignment1
Run application	dotnet run
Build application	dotnet build
Main menu option	Press 1, 2, or 3
Return to menu	Press any key
Exit application	Press 4
Clear console	Console.Clear() (automatic)
Sample Run Sequence
text
╔═══════════════════════════════════════════════╗
║        DCIT318 ASSIGNMENT 1                  ║
║        THREE APPLICATIONS IN ONE             ║
╠═══════════════════════════════════════════════╣
║  1. Grade Calculator                         ║
║  2. Ticket Price Calculator                  ║
║  3. Triangle Type Identifier                 ║
║  4. Exit                                     ║
╚═══════════════════════════════════════════════╝

Enter your choice (1-4): 1

╔═══════════════════════════════════════════════╗
║           GRADE CALCULATOR                   ║
╚═══════════════════════════════════════════════╝

Enter grade (0-100): 85

✅ Numerical Grade: 85
✅ Letter Grade:    B

Press any key to return to main menu...
The combined application makes it easy to launch and switch between all three calculators with a simple menu system!

