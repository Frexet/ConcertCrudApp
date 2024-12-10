# Concert CRUD App 🎵🎫

A console application for managing concerts with Create, Read, Update, and Delete (CRUD) functionality. This app simulates a basic ticket management system.

## Features 📋

- **Add new concerts**: Register concerts with location, performer, date, capacity, and ticket price.  
- **View all concerts**: Display all registered concerts in a user-friendly list.  
- **Update concert details**: Edit information for an existing concert.  
- **Delete concerts**: Remove outdated or irrelevant concerts.  
- **Save and load data**: Persist concert data between sessions using a text file.  

## Technical Overview 💻

- **Language**: C#  
- **Framework**: .NET (Console Application)  
- **Data Storage**: Text file (`Concerts.txt`)  

### Project Structure  

1. **`Concert` Class**:  
   Represents a concert with properties like location, performer, date, capacity, and ticket price.

2. **`ConcertManager` Class**:  
   Handles all concert-related operations, including CRUD functionality and file management.

3. **`Program` Class**:  
   Manages the user interface through a console-based menu system.

## Requirements 🛠️

- .NET SDK (version X or higher)  
- Compatible text editor/IDE (Visual Studio, Rider, VS Code, etc.)  

## How to Run 🚀

1. **Clone the repository**:  
   ```bash
   git clone https://github.com/Frexet/ConcertCrudApp.git
   cd ConcertCrudApp
