This project is a basic chat application developed using .NET and SignalR. The project uses SignalR to allow users to chat in real time while storing its data in a SQL database. This README file provides information about the overall structure, requirements, and setup of the project. <br>
📝 Features<br>
Real-Time Messaging: Fast and low-latency communication with SignalR.<br>
User Management: Each user must log in.<br>
Message Storage: Sent and received messages are stored in SQL database.<br>
User-Friendly Interface: Ease of use with a clean and minimalist interface.<br>
📌 Technologies <br>
Backend: .NET Core<br>
Real-Time Communication: SignalR<br>
Database: SQL Server<br>
Other: ASP.NET Core MVC<br>
⚙️ Installation<br>
Requirements<br>
.NET SDK 6.0 or later<br>
SQL Server (Express or later)<br>
Git<br>
Installation Steps<br>
Clone the project from GitHub:<br>

<b>git clone https://github.com/muhammederencennetkusu/dotnet-basic-chatapp</b><br>
<b>cd chatapp-projesi</b><br>
Install the necessary dependencies:<br>

<b>dotnet restore</b><br>
Create a database in SQL Server and add the connection information to the appsettings.json file.<br>
<br>
Run the dotnet ef commands to create the database tables and set up the tables:<br>

<b>dotnet ef database update</b><br>
Start the application:<br>

<b>dotnet run</b><br>
View the application by opening http://localhost:5000 in your browser.<br>

🚀 Usage<br>
Log in with your username by logging in or registering on the homepage.<br>
After choosing a username, you can join the chat room and send messages.<br>
The messages sent are instantly displayed on other users' screens will appear.<br>
translate this to English
